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
        public mySqlLogin()
        {
            InitializeComponent();
            xmlLoad();
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            DBConnect.OpenConnection();
            if (DBConnect.isConnectionOpen)
            {
                MessageBox.Show("It looks like it's working! Or is it...", "Connection Info");
                DBConnect.CloseConnection();
            }
            else
            {
                MessageBox.Show("Connection Problem.");
            }
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

        public string[] xmlLoad()
        {
            string[] dbcon = new string[5];

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml"))
            {
                XmlTextReader xmltext = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml");

                int i = 0;
                while (xmltext.Read())
                {
                    switch (xmltext.NodeType)
                    {
                        case XmlNodeType.Text:
                            dbcon[i] = xmltext.Value;
                            i++;
                            break;
                    }
                }
                // Close it or the app goes nuts at me...
                xmltext.Close();

                hostTextBox.Text = dbcon[0];
                usernameTextBox.Text = dbcon[1];
                passwordTextBox.Text = dbcon[2];
                portTextBox.Text = dbcon[3];
                databaseTextBox.Text = dbcon[4];

                return dbcon;
            }
            else
            {
                MessageBox.Show("Could not find a XML config file saved, please create a new one.", "Error");
                return null;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
