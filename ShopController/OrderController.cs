using ShopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopController
{
    public class OrderController : IController<Order>
    {
        public ShopModel.ShopModel db;

        public OrderController()
        {
            db = new ShopModel.ShopModel();
        }

        public bool IsPossible(Order t)
        {
            bool isPossible = true;
            foreach (Order_Item item in t.Order_Item)
                if (item.Quantity > db.Products.SingleOrDefault(x => x.Product_Id == item.Product_Id).Stock)
                    isPossible = false;
            return isPossible;
        }

        public bool Create(Order t)
        {
            int i = 0;
            if (t != null && IsPossible(t))
            {
                db.Orders.Add(t);
                foreach (Order_Item item in t.Order_Item)
                {
                    db.Order_Item.Add(item);
                    db.Products.SingleOrDefault(x => x.Product_Id == item.Product_Id).Stock -= item.Quantity;
                }
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public Order Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReadAll()
        {
            return db.Orders.ToList<Order>();
        }
        public bool Update(Order t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order t)
        {
            throw new NotImplementedException();
        }

        public int GetTimestamp(int id)
        {
            throw new NotImplementedException();
        }


    }
}
