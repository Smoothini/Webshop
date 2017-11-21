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
    public partial class ProductWindow : Form
    {
        ProductReference.IProduct productRef;
        CategoryReference.ICategory categoryRef;
        public ProductWindow()
        {
            InitializeComponent();
        }

        void prepareComboBoxes()
        {
            /*List<string> cats = new List<string>(categoryRef.GetCategoriesAsList());
            foreach (string cat in cats)
            {
                categoryComboBox.Items.Add(cat);
                newCategoryComboBox.Items.Add(cat);
            }*/
        }
        /*
        string IdToName(int id)
        {
            //return categoryRef.IdToName(id);
        }

        int NameToId(string name)
        {
            //return categoryRef.NameToId(name);
        }*/

        private void ProductWindow_Load(object sender, EventArgs e)
        {
            productRef = new ProductReference.ProductClient();
            categoryRef = new CategoryReference.CategoryClient();
            prepareComboBoxes();
            refreshButton.PerformClick();
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            productsBox.Items.Clear();
            productsBox.Items.AddRange(productRef.ReadAllAsList());
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            /*if (productRef.Create(nameBox.Text, descBox.Text, NameToId(categoryComboBox.SelectedItem.ToString()), int.Parse(stockBox.Text), decimal.Parse(priceBox.Text)))
                createMessage.Text = "Product succesfully created";
            else
                createMessage.Text = "Error, please check input details";
            refreshButton.PerformClick();*/
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            /*if (productRef.Update(productsBox.SelectedItem.ToString(), newNameBox.Text, newDescBox.Text, NameToId(newCategoryComboBox.SelectedItem.ToString()), int.Parse(newStockBox.Text), decimal.Parse(newPriceBox.Text)))
                messageExtra.Text = "Product succesfully updated!";
            else
                messageExtra.Text = "Error in updating product";
            refreshButton.PerformClick();*/
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            if (productRef.Restock(productsBox.SelectedItem.ToString(), int.Parse(addedStockBox.Text)))
                messageExtra.Text = "Stock added succesfully";
            else
                messageExtra.Text = "Error adding new stock";
            refreshButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productRef.Delete(productsBox.SelectedItem.ToString()))
                messageExtra.Text = "Product succesfully deleted";
            else
                messageExtra.Text = "Error deleting";
            refreshButton.PerformClick();
        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (productsBox.SelectedItem != null)
            {
                string[] details = productRef.GetProductDetails(productsBox.SelectedItem.ToString());
                newNameBox.Text = details[0];
                newDescBox.Text = details[1];
                newCategoryComboBox.SelectedItem = IdToName(int.Parse(details[2]));
                newStockBox.Text = details[3];
                newPriceBox.Text = details[4];
            }*/
        }
    }
}
