using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopModel;

namespace ShopFormsClient
{
    public partial class CategoryWindow : Form
    {
        CategoryReference.ICategory categoryRef;
        public CategoryWindow()
        {
            InitializeComponent();
            categoryRef = new CategoryReference.CategoryClient();
        }

        private void CategoryWindow_Load(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void createCategory_Click(object sender, EventArgs e)
        {/*
            createLabel.Visible = true;
            if (categoryRef.CreateCategory(newCategory.Text))
                createLabel.Text = "Category successfuly created";
            else
                createLabel.Text = "Category already exists";
            newCategory.Clear();
            refreshButton.PerformClick();*/
        }
        private void renameButton_Click(object sender, EventArgs e)
        {/*
            createLabel.Visible = true;
            if (categoryRef.UpdateCategory(categoriesBox.SelectedItem.ToString(), newNameBox.Text.ToString(), Timestamp))
                createLabel.Text = "Succesfully renamed";
            else
                createLabel.Text = "Error renaming category";
            newNameBox.Clear();
            refreshButton.PerformClick();*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {/*
            if (categoryRef.DeleteCategory(categoriesBox.SelectedItem.ToString()))
                createLabel.Text = "Category succesfully deleted";
            refreshButton.PerformClick();*/
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            categoriesBox.Items.Clear();
            //List<Category> cats = categoryRef.ReadAll().ToList<Category>();

            categoriesBox.Items.Add(categoryRef.Read(4).ToString());

            //foreach(Category cat in cats)
            {
              //  categoriesBox.Items.Add(cat);
            }
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (categoriesBox.SelectedItem == null)
                newNameBox.Clear();
            else
            {
                newNameBox.Text = categoriesBox.SelectedItem.ToString();
                Timestamp = categoryRef.GetTimestamp(categoriesBox.SelectedItem.ToString());
            }*/
        }
    }
}
