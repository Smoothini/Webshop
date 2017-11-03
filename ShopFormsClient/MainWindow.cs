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
    public partial class MainWindow : Form
    {
        UserWindow userWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userWindow = new UserWindow();
            userWindow.Show();
        }
    }
}
