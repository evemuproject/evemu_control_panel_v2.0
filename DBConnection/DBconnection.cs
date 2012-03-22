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

        // Simple Query: Handles INSERT, UPDATE, DELETE, ALTER and others i may have forgotten...
        public void SQuery(string query)
        {
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

        // Advanced Query: Handles Multi-SELECT and return the values as a DataTable
        public DataTable AQuery(string query)
        {
            MySqlCommand myquery = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader dataread1 = myquery.ExecuteReader();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                var datatable = new DataTable();
                dataread1.Close();
                adapter.SelectCommand = myquery;
                adapter.Fill(datatable);

                // Close it
                connection.Close();

                return datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            return null;
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
