using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopBusiness;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Category" in both code and config file together.
    public class Category : ICategory
    {
        CategoryController categoryController;
        public Category()
        {
            categoryController = new CategoryController();
        }

        public bool CreateCategory(string name)
        {
            return categoryController.Create(name);
        }
        public void ReadCategory(int id)
        {
            //To be made in china
            throw new NotImplementedException();
        }
        public bool UpdateCategory(string oldName, string newName, int stamp)
        {
            return categoryController.Update(oldName, newName, stamp);
        }

        public bool DeleteCategory(string name)
        {
            return categoryController.DeleteByName(name);
        }

        public List<string> GetCategoriesAsList()
        {
            return categoryController.GetCategoriesAsList();
        }

        public string IdToName(int id)
        {
            return categoryController.IdToName(id);
        }

        public int NameToId(string name)
        {
            return categoryController.NameToId(name);
        }

        public int GetTimestamp(string name)
        {
            return categoryController.GetStamp(name);
        }

        public bool CheckTimestamp(string name, int stamp)
        {
            return stamp == GetTimestamp(name);
        }
    }
}
