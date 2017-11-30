﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Checkout : System.Web.UI.Page
    {
        OrderReference.IOrder orderRef;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
            orderRef = new OrderReference.OrderClient();
        }

        public void LoadOrderDetails()
        {
            if(Request.Cookies["carttotal"] != null)
            {
                OrderDetails.Text = "Your total payment is " + Request.Cookies["carttotal"].Value;
            }
        }

        protected void PlaceOrder_Click(object sender, EventArgs e)
        {
            if (NotEmptyCart())
            {
                if (LuhnChecker(CardInput.Text))
                {
                    if (orderRef.Create(CartToOrder()))
                    {
                        EmptyCart();
                        OrderStatus.Text = "Payment made and order succesfully placed";
                    }
                    else
                        OrderStatus.Text = "Error, cart is empty";
                }
                else
                    OrderStatus.Text = "Error, please input a valid credit card";
            }
        }

        public bool LuhnChecker(string input)
        {
            return input.All(char.IsDigit) && input.Reverse()
            .Select(c => c - 48)
            .Select((thisNum, i) => i % 2 == 0
                ? thisNum : ((thisNum *= 2) > 9 
                                    ? thisNum - 9 : thisNum)
            ).Sum() % 10 == 0;
        }

        public void EmptyCart()
        {
            if (Request.Cookies["shoppingcart"] != null)
            {
                HttpCookie cookie = new HttpCookie("shoppingcart");
                cookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(cookie);
                HttpCookie total = new HttpCookie("carttotal");
                total.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(total);
            }
        }

        public bool NotEmptyCart()
        {
            return (Request.Cookies["shoppingcart"] != null);
        }

        public OrderReference.TOrder CartToOrder()
        {
            OrderReference.TOrder order = new OrderReference.TOrder();
            if(NotEmptyCart())
            {
                order.orderid = 0;
                order.userid = 2020;
                order.date = DateTime.Now.ToString();
                order.isDelivered = false;
                order.price = decimal.Parse(Request.Cookies["carttotal"].Value);
            }
            return order;
        }
    }
}