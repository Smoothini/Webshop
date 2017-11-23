using System;
using System.Collections.Generic;
using System.Linq;
using ShopModel;

namespace ShopController
{
    public class CategoryController : IController<Category>
    {
        ShopModel.ShopModel model;
        Category category;
        List<Category> categories;

        public CategoryController()
        {
            model = new ShopModel.ShopModel();
            category = new Category();
            categories = new List<Category>();
        }

        public bool Create(Category t)
        {
            if (t != null)
            {
                model.Categories.Add(t);
                model.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public Category Read(int id)
        {
            return model.Categories.SingleOrDefault(x => x.Category_Id == id);
        }

        public List<Category> ReadAll()
        {
            return model.Categories.ToList<Category>();
        }
        public bool Update(Category t)
        {
            if (t != null)
            {
                if (t.Timestamp == GetTimestamp(t.Category_Id))
                {
                    category = model.Categories.SingleOrDefault(x => x.Category_Id == t.Category_Id);
                    category.Name = t.Name;
                    category.Timestamp++;
                    model.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool Delete(Category t)
        {
            if (t != null)
            {
                if (t.Timestamp == GetTimestamp(t.Category_Id))
                {
                    t = model.Categories.SingleOrDefault(x => x.Category_Id == t.Category_Id);
                    model.Categories.Remove(t);
                    model.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public int GetTimestamp(int id)
        {
            category = model.Categories.SingleOrDefault(x => x.Category_Id == id);
            if (category != null)
                return category.Timestamp;
            else
                return -1;
        }
    }
}
