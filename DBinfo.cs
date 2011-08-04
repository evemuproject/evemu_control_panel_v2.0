using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
    }
}
