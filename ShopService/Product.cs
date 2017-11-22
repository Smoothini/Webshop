using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopController;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Product" in both code and config file together.
    public class Product : IProduct
    {
        ProductController productController;
        public Product()
        {
            productController = new ProductController();
        }
        public bool Create(string name, string description, int category, int stock, decimal price)
        {
            return productController.Create(name, description, category, stock, price);
        }

        public bool Delete(string name)
        {
            return productController.Delete(name);
        }

        public string[] GetProductDetails(string name)
        {
            return productController.GetProductDetails(name);
        }

        public List<string> ReadAllAsList()
        {
            return productController.ReadAllAsList();
        }

        public bool Update(string name, string newName, string newDescription, int newCategory, int newStock, decimal newPrice)
        {
            return productController.Update(name, newName, newDescription, newCategory, newStock, newPrice);
        }

        public bool Restock(string name, int quantity)
        {
            return productController.Restock(name, quantity);
        }
    }
}
