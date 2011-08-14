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

namespace EveControlPanelApplication
{

    public class DBConnect
    {
        private MySqlConnection connection;
        private EveControlPanelApplication.mySqlLogin DBinfo = new EveControlPanelApplication.mySqlLogin();

        //open connection to database
        public bool OpenConnection()
        {
            string[] dbcon = DBinfo.xmlLoad();
            string connectionString = "SERVER=" + dbcon[0] + ";" + "DATABASE=" +
            dbcon[4] + ";" + "UID=" + dbcon[1] + ";" + "PASSWORD=" + dbcon[2] + ";";
            connection = new MySqlConnection(connectionString);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        public void Insert()
        {
            string query = "INSERT INTO tabelinfo (age) VALUES('32')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
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
