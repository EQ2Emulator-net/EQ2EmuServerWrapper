using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Net;

namespace EQ2EmuServerWrapper
{
    public class Settings
    {
        public static void Load()
        {
            if (!File.Exists("settings.xml"))
                return;

            XmlReader reader = XmlReader.Create("settings.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Server")
                {

                    if (reader.GetAttribute(0) == "World")
                    {
                        reader.Read();
                        if (reader.NodeType == XmlNodeType.Text)
                        {
                            Form1.world_path = reader.Value;
                        }
                    }
                    else if (reader.GetAttribute(0) == "Login")
                    {
                        reader.Read();
                        if (reader.NodeType == XmlNodeType.Text)
                        {
                            Form1.login_path = reader.Value;
                        }
                    }
                }
            }
                    
            reader.Close();
        }

        public static void Save(string world_path, string login_path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create("settings.xml", settings);
            writer.WriteStartDocument();
            writer.WriteComment("EQ2EmuServerWrapper settings, used to store paths to servers");

            writer.WriteStartElement("EQ2EmuServerWrapper");

            if (!string.IsNullOrEmpty(world_path))
            {
                writer.WriteStartElement("Server");
                writer.WriteAttributeString("Type", "World");
                writer.WriteString(world_path);
                writer.WriteEndElement();
            }

            if (!string.IsNullOrEmpty(login_path))
            {
                writer.WriteStartElement("Server");
                writer.WriteAttributeString("Type", "Login");
                writer.WriteString(login_path);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }
        /* Sample XML File
         * 
         * <Server Type="World">C:/EQ2Emu/EQ2World.exe</Server>
         * <Server Type="Login">C:/EQ2Emu/EQ2Login.exe</Server>
         */


    }
}
