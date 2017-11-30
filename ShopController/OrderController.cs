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

        public bool Create(Order t)
        {
            if (t != null)
            {
                db.Orders.Add(t);
                db.SaveChanges();
                //db.Order_Item.AddRange(t.Order_Item);
                //db.SaveChanges();
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
            throw new NotImplementedException();
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
