using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Diagnostics;
using System.Threading;
using System.IO;

namespace EQ2EmuServerWrapper
{
    public partial class Form1 : Form
    {
        Process WorldServer = null;
        Process LoginServer = null;

        bool close_pending = false;

        public static string world_path;
        public static string login_path;

        public Form1()
        {
            InitializeComponent();

            // Load world server console
            ConsoleControl con = new ConsoleControl();
            tpWorldAll.Controls.Add(con);
            con.Dock = DockStyle.Fill;

            // Load login server console
            ConsoleControl con2 = new ConsoleControl();
            tpLoginAll.Controls.Add(con2);
            con2.Dock = DockStyle.Fill;

            // Load settings
            Settings.Load();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(world_path))
            {
                MessageBox.Show("World server path not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WorldServer = new Process();
            WorldServer.StartInfo.FileName = world_path;
            WorldServer.StartInfo.WorkingDirectory = world_path.Substring(0, world_path.LastIndexOf('\\'));
            WorldServer.StartInfo.UseShellExecute = false;
            WorldServer.StartInfo.RedirectStandardError = true;
            WorldServer.StartInfo.RedirectStandardOutput = true;
            WorldServer.StartInfo.RedirectStandardInput = true;
            WorldServer.StartInfo.CreateNoWindow = true;
            WorldServer.Start();

            WorldServer.StandardInput.AutoFlush = true;

            Thread thread = new Thread(new ThreadStart(StartServer));
            thread.Start();

            Thread thread2 = new Thread(new ThreadStart(ServerStats));
            thread2.Start();
        }

        private void btnStartLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_path))
            {
                MessageBox.Show("Login server path not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginServer = new Process();
            LoginServer.StartInfo.FileName = login_path;
            LoginServer.StartInfo.WorkingDirectory = login_path.Substring(0, login_path.LastIndexOf('\\'));
            LoginServer.StartInfo.UseShellExecute = false;
            LoginServer.StartInfo.RedirectStandardError = true;
            LoginServer.StartInfo.RedirectStandardOutput = true;
            LoginServer.StartInfo.RedirectStandardInput = true;
            LoginServer.StartInfo.CreateNoWindow = true;
            LoginServer.Start();

            Thread thread = new Thread(new ThreadStart(StartLoginServer));
            thread.Start();
        }

        private void StartServer()
        {
            while (!WorldServer.StandardOutput.EndOfStream)
            {
                //  Just keep on reading the buffer.
                int count = 0;
                char[] buffer = new char[65535];
                do
                {
                    //  Create a builder.
                    StringBuilder builder = new StringBuilder();

                    //  Read and append data.
                    count = WorldServer.StandardOutput.Read(buffer, 0, 65535);
                    builder.Append(buffer, 0, count);

                    OutputAddLine(builder.ToString());
                } while (count > 0);
            }

            WorldServer.Close();
            WorldServer = null;
            OutputAddLine("Server closed!");
            if (close_pending)
                this.Invoke((MethodInvoker)(() => this.Close()));
        }

        private void StartLoginServer()
        {
            while (!LoginServer.StandardOutput.EndOfStream)
            {
                int count = 0;
                char[] buffer = new char[65535];
                do
                {
                    StringBuilder builder = new StringBuilder();

                    count = LoginServer.StandardOutput.Read(buffer, 0, 65535);
                    builder.Append(buffer, 0, count);

                    OutputAddLine(builder.ToString(), 1);
                } while (count > 0);
            }
            LoginServer.Close();
            LoginServer = null;
        }

        private void ServerStats()
        {
            if (WorldServer == null)
                return;

            while (WorldServer != null)
            {
                try
                {
                    using (PerformanceCounter cpuUsage = new PerformanceCounter("Process", "% Processor Time", "_Total"))
                    using (PerformanceCounter pcProcess = new PerformanceCounter("Process", "% Processor Time", WorldServer.ProcessName))
                    //using (PerformanceCounter memProcess = new PerformanceCounter("Memory", "Available MBytes"))
                    {
                        // Prime the Performance Counters
                        cpuUsage.NextValue();
                        pcProcess.NextValue();
                        WorldServer.Refresh();

                        Thread.Sleep(100);

                        // Get CPU Usage
                        double cpuUse = Math.Round(pcProcess.NextValue() / cpuUsage.NextValue() * 100, 2);

                        // Check for Not-A-Number (Division by Zero)
                        if (Double.IsNaN(cpuUse))
                            cpuUse = 0;

                        
                        UpdateCPUStat(cpuUse.ToString());

                        // Get Process Memory Usage                    
                        double memUseage = WorldServer.WorkingSet64 / 1024; // 1024 for KB 1048576 for MB
                        UpdateMemStat(String.Format("{0:n}", memUseage));

                        /*
                        // Get Total RAM free
                        float mem = memProcess.NextValue();
                        */

                        Thread.Sleep(400); // total of 500 delay, 0.5 sec
                    }
                }
                catch (Exception e)
                {
                    // Added this try catch as it was possible for the world server to close while in the while loop causing a crash, this prevents it
                }
            }
        }

        private void UpdateCPUStat(string cpu)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { UpdateCPUStat(cpu); }));
                return;
            }

            label2.Text = cpu + "%";
        }

        private void UpdateMemStat(string mem)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { UpdateMemStat(mem); }));
                return;
            }

            label4.Text = mem + "K" ;
        }

        private void OutputAddLine(string line, byte server = 0)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { OutputAddLine(line, server); }));
                return;
            }

            RichTextBox rtb;
            if (server == 0)
                rtb = ((ConsoleControl)tpWorldAll.Controls[0]).rtbOutput;
            else
                rtb = ((ConsoleControl)tpLoginAll.Controls[0]).rtbOutput;

            // Check to see if it is a log
            if (line.IndexOf(':') == 2)
            {
                OutputAddLog(rtb, line);

                string temp = line.Substring(11);
                string category = temp.Substring(0, temp.IndexOf(':'));
                category = category.Trim();

                TabControl tc;
                if (server == 0)
                    tc = tcWorldLogs;
                else
                    tc = tcLoginLogs;

                if (tc.TabPages.ContainsKey(category))
                {
                    // Add the line to the consol on the correct tab
                    rtb = ((ConsoleControl)tc.TabPages[tc.TabPages.IndexOfKey(category)].Controls[0]).rtbOutput;
                    OutputAddLog(rtb, line);
                }
                else
                {
                    // Add a new tab for the category
                    tc.TabPages.Add(category, category);
                    // Get the new tab
                    TabPage page = tc.TabPages[tc.TabPages.IndexOfKey(category)];
                    // Create a new console control
                    ConsoleControl con = new ConsoleControl();
                    // Add the new console control to the new tab
                    page.Controls.Add(con);
                    // Set the console control to fill up the entire tab
                    con.Dock = DockStyle.Fill;
                    // Add the line to the console
                    rtb = ((ConsoleControl)page.Controls[0]).rtbOutput;
                    OutputAddLog(rtb, line);
                }
            }
            else
            {
                // Not a log just add it to the "All" tab
                rtb.AppendText(line);
            }
        }

        private void OutputAddLog(RichTextBox rtb, string line)
        {
            string time = line.Substring(0, 9);
            string type = line.Substring(9, 1);
            string temp = line.Substring(11);
            string category = temp.Substring(0, temp.IndexOf(':'));
            string log = temp.Substring(temp.IndexOf(':'));
            Color color;

            switch (type)
            {
                case "E":   // Error
                    color = Color.Red;
                    break;
                case "D":   // Debug
                    color = Color.Green;
                    break;
                case "W":   // Warning
                case "P":   // Packet
                case "T":   // Trace
                    color = Color.Yellow;
                    break;
                case "Q":   // Query
                case "R":   // Result
                    color = Color.Cyan;
                    break;
                default:    // Info and anything missed
                    color = Color.White;
                    break;
            }

            rtb.SelectionColor = Color.White;
            rtb.AppendText(time);
            rtb.SelectionColor = color;
            rtb.AppendText(type + " ");
            rtb.SelectionColor = Color.White;
            rtb.AppendText(category);
            rtb.SelectionColor = color;
            rtb.AppendText(log);
            rtb.SelectionColor = Color.White;
        }

        private void ConsoleInput(string cmd)
        {
            WorldServer.StandardInput.WriteLineAsync(cmd);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ConsoleInput("exit");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoginServer != null)
                LoginServer.Kill();

            if (WorldServer != null)
            {
                Process[] processlist = Process.GetProcesses();
                foreach (Process theprocess in processlist)
                {
                    if (theprocess.Id == WorldServer.Id)
                    {
                        e.Cancel = true;
                        close_pending = true;
                        ConsoleInput("exit");
                        return;
                    }
                }
            }
        }

        void WorldServer_Exited(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPath_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubmit;
        }

        private void txtPath_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ConsoleInput(txtPath.Text);
            txtPath.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openWorldServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                world_path = ofd.FileName;
                Settings.Save(world_path, login_path);
            }
        }

        private void openLoginServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                login_path = ofd.FileName;
                Settings.Save(world_path, login_path);
            }
        }

        private void clearMainConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ConsoleControl)tpWorldAll.Controls[0]).rtbOutput.Text = string.Empty;
        }

        private void clearAllConsolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tcWorldLogs.TabPages)
                ((ConsoleControl)page.Controls[0]).rtbOutput.Text = string.Empty;
        }
    }
}
