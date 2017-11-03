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
        UserReference.IUser user;
        public UserWindow()
        {
            InitializeComponent();
            user = new UserReference.UserClient();
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webshopUserDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.webshopUserDataSet.User);
            

        }
    }
}
