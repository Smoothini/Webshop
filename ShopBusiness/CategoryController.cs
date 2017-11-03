using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopData;

namespace ShopBusiness
{
    class CategoryController : IController<Category>
    {
        ShopModel model;
        Category category;
        List<Category> categories;

        public CategoryController()
        {
            model = new ShopModel();
        }

        public bool Create(string name)
        {
            bool isCreated = true;
            category = new Category();
            category = model.Categories.SingleOrDefault(x => x.Name == name);
            if (category == null)
            {
                category = new Category()
                {
                    Name = name
                };
                model.SaveChanges();
            }
            else
                isCreated = false;
            return isCreated;
        }

        public Category Read(int id)
        {
            category = new Category();
            category = model.Categories.SingleOrDefault(x => x.Category_Id == id);
            return category;
        }

        public List<Category> ReadAll()
        {
            categories = new List<Category>();
            categories = model.Categories.ToList();
            return categories;
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
