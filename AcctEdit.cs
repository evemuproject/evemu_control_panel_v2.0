using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveControlPanelApplication
{
    public partial class acctEditForm : Form
    {
        //roles list
        private const long DEV = 5003499186008621056L;
        private const long PLAYER = 6917529027641081856L;

        public acctEditForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (usernameTX.Text != "" && passwordTX.Text != "")
            {
                try
                {
                    if (comboBox1.SelectedIndex == 0) //Dev account
                    {
                        DBConnect.SQuery("INSERT INTO acount (accountID, accountName, role, password, banned, online)" +
                                            "VALUES (NULL, '" + usernameTX.Text + "', " + DEV + ", '" + passwordTX.Text + "', 0, 0)");
                        MessageBox.Show("Dev account added!");
                    }
                    else if (comboBox1.SelectedIndex == 1) //Player account
                    {
                        DBConnect.SQuery("INSERT INTO account (accountID, accountName, role, password, banned, online)" +
                                            "VALUES (NULL, '" + usernameTX.Text + "', " + PLAYER + ", '" + passwordTX.Text + "', 0, 0)");
                        MessageBox.Show("Player account added!");
                    }
                }
                catch (InvalidExpressionException)
                {
                    MessageBox.Show("Error: You might not have installed MySql, please make you have done so.", "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error");
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = DBConnect.AQuery("SELECT accountName FROM account WHERE accountName='" + usernameFindTX.Text + "*'");
                Console.WriteLine(data.Rows.ToString());
                foreach (DataRow row in data.Rows)
                {
                    Console.WriteLine(row);
                    usernameListBox.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
