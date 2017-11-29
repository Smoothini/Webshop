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
            ListItem all = new ListItem("Everything", "all");
            ListCategories.Items.Add(all);
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
                ImageButton viewButton = new ImageButton();

                nameLabel.Text = prod.name;
                priceLabel.Text = prod.price.ToString();
                viewButton.ImageUrl = "resources/checkbtn.png";
                viewButton.PostBackUrl = "Product.aspx?id=" + prod.id;

                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(viewButton);

                PanelProducts.Controls.Add(productPanel);
            }
        }
    }
}