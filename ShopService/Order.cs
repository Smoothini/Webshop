﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Transporter;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Order" in both code and config file together.
    public class Order : IOrder
    {
        public bool Create(TOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
