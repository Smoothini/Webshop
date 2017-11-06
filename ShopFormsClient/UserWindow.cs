using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopFormsClient
{
    public partial class UserWindow : Form
    {
        UserReference.IUser userRef;
        public UserWindow()
        {
            InitializeComponent();
        }
        private void UserWindow_Load(object sender, EventArgs e)
        {
            userRef = new UserReference.UserClient();
            refreshButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userRef.DeleteUser(usersBox.SelectedItem.ToString()))
                messageDelete.Text = "User succesfully removed";
            else
                messageDelete.Text = "Error removing the user";
            refreshButton.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            usersBox.Items.Clear();
            usersBox.Items.AddRange(userRef.GetUsersAsList());
        }

        private void usersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(usersBox.SelectedItem != null)
            {
                string[] details = new string[4];
                details = userRef.GetUserDetails(usersBox.SelectedItem.ToString());
                nameBox.Text = details[0];
                emailBox.Text = details[1];
                addressBox.Text = details[2];
                phoneBox.Text = details[3];
            }
        }

        private void ordersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
