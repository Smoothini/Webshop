using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Main : System.Web.UI.Page
    {
        ProductReference.IProduct prodRef;
        CategoryReference.ICategory catRef;
        List<ProductReference.TProduct> prods;
        List<CategoryReference.TCategory> cats;
        List<Button> buttons;
        protected void Page_Load(object sender, EventArgs e)
        {
            Prepare();
            LoadCategories();
            LoadProducts();
        }

        public void Prepare()
        {
            prodRef = new ProductReference.ProductClient();
            catRef = new CategoryReference.CategoryClient();
            prods = new List<ProductReference.TProduct>(prodRef.ReadAll());
            cats = new List<CategoryReference.TCategory>(catRef.ReadAll());
        }

        public void LoadCategories()
        {
            foreach(CategoryReference.TCategory cat in cats)
            {
                ListItem item = new ListItem(cat.name, cat.id.ToString());
                ListCategories.Items.Add(item);
            }
        }

        public void LoadProducts()
        {
            foreach (ProductReference.TProduct prod in prods)
            {
                Panel productPanel = new Panel();
                Label nameLabel = new Label();
                Label priceLabel = new Label();
                HyperLink viewLink = new HyperLink();
                ImageButton viewButton = new ImageButton();

                nameLabel.Text = prod.name;
                priceLabel.Text = prod.price.ToString();
                viewButton.PostBackUrl = "~Product.aspx?id=" + prod.id;

                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(viewLink);

                PanelProducts.Controls.Add(productPanel);
            }

            string TopRow = @"<table>
                                <tr>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Description</th>
                                    <th>Price</th>
                                </tr>";
            string Bottom = @"</table>";
            Literal1.Text += TopRow;
            foreach(ProductReference.TProduct prod in prods)
            {
                Literal1.Text += "<tr>";
                Literal1.Text += "<td>" + prod.id + "</td>";
                Literal1.Text += "<td>" + prod.name + "</td>";
                Literal1.Text += "<td>" + prod.description + "</td>";
                Literal1.Text += "<td>" + prod.price + "</td>";
                Literal1.Text += "<td>Button goes here</td>";
                Literal1.Text += "</tr>";
            }
            Literal1.Text += Bottom;
        }
    }
}