using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopController;
using ShopService.Transporter;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Order" in both code and config file together.
    public class Order : IOrder
    {
        public OrderController controller;
        public Order()
        {
            controller = new OrderController();
        }

        ShopModel.Order TransporterToModel(TOrder torder)
        {
            ShopModel.Order order = new ShopModel.Order
            {
                Order_Id = torder.orderid,
                User_Id = torder.userid,
                Date = torder.date,
                IsDelivered = false,
                Price = torder.price
            };
            foreach(TOrderItem titem in torder.items)
            {
                ShopModel.Order_Item item = new ShopModel.Order_Item
                {
                    Product_Id = titem.productid,
                    Order_Id = titem.orderid,
                    Quantity = titem.quantity,
                    Price = titem.price
                };
                order.Order_Item.Add(item);
            }
            return order;
        }

        public bool Create(TOrder order)
        {
            return controller.Create(TransporterToModel(order));
        }
    }
}
