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
    public partial class CategoryWindow : Form
    {
        CategoryReference.ICategory categoryRef;
        public CategoryWindow()
        {
            InitializeComponent();
            categoryRef = new CategoryReference.CategoryClient();
            refreshButton.PerformClick();
        }

        private void createCategory_Click(object sender, EventArgs e)
        {
            createLabel.Visible = true;
            if (categoryRef.CreateCategory(newCategory.Text))
                createLabel.Text = "Category successfuly created";
            else
                createLabel.Text = "Category already exists";
            refreshButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            categoryRef.DeleteCategory(categoriesBox.SelectedItem.ToString());
            refreshButton.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            categoriesBox.Items.Clear();
            List<string> items = categoryRef.GetCategoriesAsList().ToList<string>();
            foreach(string cat in items)
            {
                categoriesBox.Items.Add(cat);
            }
        }
        
    }
}
