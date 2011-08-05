using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;
using EveControlPanelApplication;

namespace EveControlPanelApplication
{
    public partial class mySqlLogin : Form
    {
        private DBConnect dbConnect;
        

        public mySqlLogin()
        {
            InitializeComponent();
           
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
             dbConnect = new DBConnect();
             dbConnect.Insert();
        }

        private void saveCloseWindow_Click(object sender, EventArgs e)
        {
            if (xmlSave())
            {
                Form.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK);
            }
        }

        // SaveNew will save a new file which will be decided whether it's a new one or and old one in the method above.

        private bool xmlSave()
        {
            // Create the information we will need.
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xmlInfo = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmlInfo);
            
            // Make the main Node.
            XmlNode ecpMain = xmlDoc.CreateElement("ecp_db");
            xmlDoc.AppendChild(ecpMain);

            // Settings
            XmlNode settings = xmlDoc.CreateElement("settings");
            ecpMain.AppendChild(settings);

            // Server
            XmlNode host = xmlDoc.CreateElement("host");
            host.AppendChild(xmlDoc.CreateTextNode(hostTextBox.Text));
            settings.AppendChild(host);

            // Username
            XmlNode username = xmlDoc.CreateElement("username");
            username.AppendChild(xmlDoc.CreateTextNode(usernameTextBox.Text));
            settings.AppendChild(username);

            // Password
            XmlNode password = xmlDoc.CreateElement("password");
            password.AppendChild(xmlDoc.CreateTextNode(passwordTextBox.Text));
            settings.AppendChild(password);

            // Port
            XmlNode port = xmlDoc.CreateElement("port");
            port.AppendChild(xmlDoc.CreateTextNode(portTextBox.Text));
            settings.AppendChild(port);

            // Database
            XmlNode database = xmlDoc.CreateElement("database");
            database.AppendChild(xmlDoc.CreateTextNode(databaseTextBox.Text));
            settings.AppendChild(database);

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml"))
            {
                // File already exists so lets save, no fuss, no muss...
                xmlDoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml");

                return true;
            }
            else
            {
                // Create the directory, if it exists from before there should not be a problem...
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\");
                
                // Create the XML, then close afterwards.
                FileStream fs = new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml"), FileMode.Create);
                fs.Close();

                // It's save time.
                xmlDoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml");

                // Return true as it saved.
                return true;
            }
        }

        private void xmlLoad()
        {
            // Not done yet..
        }
    }
}
