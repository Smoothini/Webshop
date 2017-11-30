using ShopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
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
