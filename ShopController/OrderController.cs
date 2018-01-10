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
            return db.Orders.FirstOrDefault(x => x.Order_Id == id);
        }

        public List<Order> ReadAll()
        {
            return db.Orders.ToList<Order>();
        }
        public bool Update(Order t)
        {
            throw new NotImplementedException("Not needed now");
        }

        public bool Delete(Order t)
        {
            if (t != null)
            {
                t = db.Orders.FirstOrDefault(x => x.Order_Id == t.Order_Id);
                db.Order_Item.RemoveRange(t.Order_Item);
                db.Orders.Remove(t);
                db.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool MarkDelivery(Order t)
        {
            if(t!=null && t.Timestamp == GetTimestamp(t.Order_Id))
            {
                t = db.Orders.FirstOrDefault(x => x.Order_Id == t.Order_Id);
                if (t.IsDelivered)
                    t.IsDelivered = false;
                else
                    t.IsDelivered = true;
                t.Timestamp++;

                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public int GetTimestamp(int id)
        {
            return db.Orders.FirstOrDefault(x => x.Order_Id == id).Timestamp;
        }


    }
}
