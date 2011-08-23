using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveControlPanelApplication;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Globalization;
using EveControlPanelApplication.src.Utilities;

namespace EveControlPanelApplication
{

    class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private EveControlPanelApplication.mySqlLogin DBinfo = new EveControlPanelApplication.mySqlLogin();
        private accountEditorForm accountEditorForm2 = new accountEditorForm();
       

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            // We need a cleaner way of doing this, i think accessing the settings we already have through the xml file.
            server = DBinfo.hostTextBox.Text;
            database = DBinfo.databaseTextBox.Text;
            uid = DBinfo.usernameTextBox.Text;
            password = DBinfo.passwordTextBox.Text;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            { 
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;

            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Example of what an insert should look like
        //public void Insert()
        //{
        //    string query = "INSERT INTO tabelinfo (age) VALUES('32')";

        //    //open connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //create command and assign the query and connection from the constructor
        //        MySqlCommand cmd = new MySqlCommand(query, connection);

        //        //Execute command
        //        cmd.ExecuteNonQuery();

        //        //close connection
        //        this.CloseConnection();
        //    }
        //}
        public static string CalculateMD5Hash(string strInput)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strInput);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        
        private void log__(string logText)
        {
            logSystem log = new logSystem();
            log.logAdd(logText);
        }
        
       
       
        public void createAccount()
        {
            
            
            string username = accountEditorForm2.newUsername.Text;
            string password = accountEditorForm2.newPassword.Text;
            string accountLevel = accountEditorForm2.newAcctLevel.Text;
            if (username != "" && password != "" && accountLevel != "")
            {
                bool success = false;
                string query = "";
                string acctrole = accountLevel;
                if (acctrole == "SUPER ADMIN")
                {
                    acctrole = "18014398509481984";
                }
                else if (acctrole == "ADMIN")
                {
                    acctrole = "32";
                }
                else if (acctrole == "GAME MASTER HIGH")
                {
                    acctrole = "16";
                }
                else if (acctrole == "GAME MASTER LOW")
                {
                    acctrole = "8";
                }
                else if (acctrole == "PLAYER")
                {
                    acctrole = "2";
                }
                else
                {
                    MessageBox.Show("You have not selected a role, the account will be \"2 (PLAYER)\" by default.");
                    acctrole = "2";
                }
                
                // Need to fix password back to MD5 hash.
                query = "INSERT INTO account (accountName, password, role) VALUES ('" + username + "', '" + password + "', '"+ accountLevel +"')";
                
                //Create the command, Must declare connection here, If not you will have an error.
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    //Open the connection
                    this.connection.Open();
                    // Set Success to true if connection is open
                    success = true;
                }
                catch (MySqlException ex)
                {
                    log__("Exception: " + ex.Message);
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    log__("Exception: " + ex.Message);
                    if (ex.Message == "Duplicate entry '" + username + "' for key 'accountName'")
                    {
                        MessageBox.Show("The account: \"" + username + "\", already exists.");
                        success = false;
                    }
                }
                catch (Exception x)
                {
                    log__("Exception: " + x.Message);
                    MessageBox.Show(x.Message);
                }

                if (success == true)
                {
                    MessageBox.Show("Account Created!");
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the fields are filled in.");
            }
            // closing the connection when done, Close all connections, leave none open when they dont need to be.
            this.connection.Close();
        }
        //Backup
        public void Backup()
        {

        }

        //Restore
        public void Restore()
        {

        }
        
      
   
    
    
    }
}
