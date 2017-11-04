using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopData;

namespace ShopBusiness
{
    public class CategoryController : IController<Category>
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
                category = new Category();
                category.Name = name;
                model.Categories.Add(category);
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

        public List<string> GetCategoriesAsList()
        {
            List<string> cats = new List<string>();
            categories = new List<Category>();
            categories = model.Categories.ToList();
            foreach (Category category in categories)
                cats.Add(category.Name.ToString());
            return cats;
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            bool isDeleted = true;
            category = new Category();
            category = model.Categories.SingleOrDefault(x => x.Category_Id == id);
            if (category != null)
            {
                model.Categories.Remove(category);
                model.SaveChanges();
            }
            else
                isDeleted = false;
            return isDeleted;
        }

        public bool DeleteByName(string name)
        {
            bool isDeleted = true;
            category = new Category();
            category = model.Categories.SingleOrDefault(x => x.Name == name);
            if (category != null)
            {
                model.Categories.Remove(category);
                model.SaveChanges();
            }
            else
                isDeleted = false;
            return isDeleted;
        }

    }
}
