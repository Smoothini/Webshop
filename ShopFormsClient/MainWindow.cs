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
        CategoryWindow categoryWindow;
        public MainWindow()
        {
            InitializeComponent();
            categoryWindow = new CategoryWindow();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            categoryWindow.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
