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
            if (usernameTX.Text != "" && passwordTX.Text != "" && userList.SelectedValue != "")
            {
                try
                {
<<<<<<< HEAD
                    if (userList.SelectedIndex == 0) //Dev account
                    {
                        DBConnect.SQuery("INSERT INTO account (accountID, accountName, role, password, banned, online)" +
                                            "VALUES (NULL, '" + usernameTX.Text + "', " + DEV + ", '" + passwordTX.Text + "', 0, 0)");
                        MessageBox.Show("Dev account added!");
                    }
                    else if (userList.SelectedIndex == 1) //Player account
                    {
                        DBConnect.SQuery("INSERT INTO account (accountID, accountName, role, password, banned, online)" +
                                            "VALUES (NULL, '" + usernameTX.Text + "', " + PLAYER + ", '" + passwordTX.Text + "', 0, 0)");
                        MessageBox.Show("Player account added!");
                    }
                }
                catch (InvalidExpressionException)
                {
                    MessageBox.Show("Error: You might not have installed MySql, please make you have done so.", "Error");
=======
                    db.SQuery("INSERT INTO account (accountName, password) VALUES ('" + usernameTX.Text + "', '" + passwordTX.Text + "')");
                    MessageBox.Show("Account '" + usernameTX.Text + "' has been created. Have fun!", "Yay!");
>>>>>>> d1ff5f9a75006568b8f3a91911990d36650b45bf
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                DataTable data = new DataTable();
                data = DBConnect.AQuery("SELECT accountID, accountName, role, banned, logonCount `online` FROM account WHERE accountName like '" + usernameFindTX.Text + "%';");
               
                userDataList.DataSource = data;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delCheckedButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                DBConnect.SQuery("DELETE FROM account WHERE accountName='" + userDataList.CurrentCell.Value + "'");
                userDataList.Rows.Remove(userDataList.CurrentRow);
=======
            usernameListBox.Items.Clear();
            DBConnect db = new DBConnect();
            try
            {
               foreach (DataRow row in db.AQuery("SELECT accountName FROM account WHERE(accountName like \'" + usernameFindTX.Text + "%\')").Rows)
                {
                    usernameListBox.Items.Add(row[0].ToString());
                }
>>>>>>> d1ff5f9a75006568b8f3a91911990d36650b45bf
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
