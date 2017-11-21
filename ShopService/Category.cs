using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopBusiness;
using ShopModel;

namespace ShopService
{
    public class Category : ICategory
    {
        CategoryController controller;
        public Category()
        {
            controller = new CategoryController();
        }

        public bool Create(ShopModel.Category t)
        {
            return controller.Create(t);
        }
        public ShopModel.Category Read(int id)
        {
            return controller.Read(id);
        }

        public List<ShopModel.Category> ReadAll()
        {
            return controller.ReadAll();
        }
        public bool Update(ShopModel.Category t)
        {
            return controller.Update(t);
        }

        public bool Delete(ShopModel.Category t)
        {
            return controller.Delete(t);
        }
    }
}
