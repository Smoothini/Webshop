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
    public partial class Login : Form
    {
        UserReference.IUser user;
        MainWindow main;
        public Login()
        {
            InitializeComponent();
            errorLabel.Hide();
            user = new UserReference.UserClient();
            main = new MainWindow();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public bool isValid(string user, string pass)
        {
            return user.Length > 0 && pass.Length > 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValid(userTextBox.Text, passwordTextBox.Text))
                if (user.Login(userTextBox.Text, passwordTextBox.Text))
                    main.Show();
                else
                    errorLabel.Show();
        }
    }
}
