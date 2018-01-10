using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShopService.Transporter;

namespace ShopFormsClient
{
    public partial class UserWindow : Form
    {
        UserReference.IUser userRef;
        TUser selected_user;
        public UserWindow()
        {
            InitializeComponent();
        }
        private void UserWindow_Load(object sender, EventArgs e)
        {
            userRef = new UserReference.UserClient();
            selected_user = new TUser();
            refreshButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userRef.Delete(selected_user))
                messageDelete.Text = "User succesfully removed";
            else
                messageDelete.Text = "Error removing the user";
            refreshButton.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            usersBox.DataSource = null;
            usersBox.DataSource = userRef.ReadAll();
        }

        private void usersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(usersBox.SelectedItem != null)
            {
                selected_user = (TUser)usersBox.SelectedItem;
                nameBox.Text = selected_user.name;
                emailBox.Text = selected_user.email;
                addressBox.Text = selected_user.address;
                phoneBox.Text = selected_user.phone;
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
