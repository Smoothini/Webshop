using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel;

namespace ShopController
{
    public class ProductController
    {
        ShopModel.ShopModel model;
        Product product;
        List<Product> products;
        public ProductController()
        {
            model = new ShopModel.ShopModel();
        }

        public bool Create(string name, string description, int category, int stock, decimal price)
        {
            bool isCreated = true;
            product = model.Products.SingleOrDefault(x => x.Name == name);
            if (product == null)
            {
                product = new Product
                {
                    Name = name,
                    Description = description,
                    Category_Id = category,
                    Stock = stock,
                    Price = price
                };
                model.Products.Add(product);
                model.SaveChanges();
            }
            else
                isCreated = false;
            return isCreated;
        }

        public bool Update(string name, string newName, string newDescription, int newCategory, int newStock, decimal newPrice)
        {
            bool isUpdated = true;
            product = new Product();
            product = model.Products.SingleOrDefault(x => x.Name == name);
            if (product != null)
                if (newName != null && newDescription != null && newCategory > 0 && newStock >= 0 && newPrice > 0)
                {
                    product.Name = newName;
                    product.Description = newDescription;
                    product.Category_Id = newCategory;
                    product.Stock = newStock;
                    product.Price = newPrice;
                    model.SaveChanges();
                }
                else
                    isUpdated = false;
            else
                isUpdated = false;

            return isUpdated;
        }

        public bool Delete(string name)
        {
            bool isDeleted = true;
            product = new Product();
            product = model.Products.SingleOrDefault(x => x.Name == name);
            if (product != null)
            {
                model.Products.Remove(product);
                model.SaveChanges();
            }
            else
                isDeleted = false;
            return isDeleted;
        }

        public List<string> ReadAllAsList()
        {
            List<string> names = new List<string>();
            products = new List<Product>();
            products = model.Products.ToList<Product>();
            foreach (Product p in products)
                names.Add(p.Name);
            return names;
        }

        public string[] GetProductDetails(string name)
        {
            string[] details = new string[5];
            product = new Product();
            product = model.Products.SingleOrDefault(x => x.Name == name);
            details[0] = product.Name;
            details[1] = product.Description;
            details[2] = product.Category_Id.ToString();
            details[3] = product.Stock.ToString();
            details[4] = product.Price.ToString();
            return details;
        }

        public bool Restock(string name, int quantity)
        {
            bool isStocked = true;
            product = new Product();
            product = model.Products.SingleOrDefault(x => x.Name == name);
            if (product != null)
                product.Stock += quantity;
            else
                isStocked = false;
            model.SaveChanges();
            return isStocked;
        }

    }
}
