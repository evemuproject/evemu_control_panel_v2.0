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

    static class DBConnect
    {
        private static MySqlConnection connection;
        public static bool isConnectionOpen = false;
        private static EveControlPanelApplication.mySqlLogin DBinfo = new EveControlPanelApplication.mySqlLogin();

        //open connection to database
        public static void OpenConnection()
        {
            string[] dbcon = DBinfo.xmlLoad();
            string connectionString = "SERVER=" + dbcon[0] + ";" + "DATABASE=" +
            dbcon[4] + ";" + "UID=" + dbcon[1] + ";" + "PASSWORD=" + dbcon[2] + ";";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                isConnectionOpen = true;
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

                isConnectionOpen = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Close connection
        public static bool CloseConnection()
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
        public static void SQuery(string query)
        {
            //open connection
            OpenConnection();
            
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            CloseConnection();
            
        }

        // Advanced Query: Handles Multi-SELECT and return the values as a DataTable
        public static DataTable AQuery(string query)
        {
            OpenConnection();

            MySqlCommand myquery = new MySqlCommand(query, connection);

            MySqlDataReader dataread1 = myquery.ExecuteReader();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable datatable = new DataTable();
            dataread1.Close();
            adapter.SelectCommand = myquery;
            adapter.Fill(datatable);

            CloseConnection();

            return datatable;
        }

        //Backup
        public static void Backup()
        {

        }

        //Restore
        public static void Restore()
        {

        }

    }
}
