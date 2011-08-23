using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using EveControlPanelApplication.src.Utilities;

namespace EveControlPanelApplication
{
    public partial class accountEditorForm : Form
    {
        private DBConnect dbConnect;
        
        public accountEditorForm()
        {
            InitializeComponent();
            
        }
       
       

       
        
        private void addNewAccount_Click(object sender, EventArgs e)
        {
            // Creates new DBconnect instance
            dbConnect = new DBConnect();     
            // Invoking the class to create account       
            dbConnect.createAccount();
        }
       
       
        
    }
}
