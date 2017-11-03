using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopData;

namespace ShopBusiness
{
    public class ProductController
    {
        ShopModel model;
        Product product;
        List<Product> products;
        public ProductController()
        {
            model = new ShopModel();
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
    }
}
