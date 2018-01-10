using System;
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
        ProductReference.IProduct prodRef;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
            orderRef = new OrderReference.OrderClient();
            prodRef = new ProductReference.ProductClient();
        }

        public void LoadOrderDetails()
        {
            if(Request.Cookies["carttotal"] != null)
            {
                OrderDetails.Text = "Your total payment is " + Request.Cookies["carttotal"].Value;
            }
            else
            {
                OrderDetails.Text = "Your cart is empty";
                CardInput.Visible = false;
                PlaceOrder.Visible = false;
            }
        }

        protected void PlaceOrder_Click(object sender, EventArgs e)
        {
            if (NotEmptyCart())
            {
                if (LuhnChecker(CardInput.Text))
                {
                    if (CreateAnOrder())
                    {
                        EmptyCart();
                        OrderStatus.Text = "Payment made and order succesfully placed ";
                    }
                    else;
                        //OrderStatus.Text = "Error, some items unavailable and removed";
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

        public bool CreateAnOrder()
        {
            bool isCreated = true;
            List<int> productsToRemove = new List<int>();
            string newCart = "";
            decimal newTotal = 0;
            string lcookies = Request.Cookies["shoppingcart"].Value;
            string[] cookies = lcookies.Split('|');
            foreach (string cookie in cookies)
            {
                string[] chip = cookie.Split(',');
                //chip[0] product id, chip[2] quantity
                if (int.Parse(chip[2]) > prodRef.StockAvailable(int.Parse(chip[0])))
                    productsToRemove.Add(int.Parse(chip[0]));
                else
                {
                    if (newCart == "")
                        newCart = chip[0] + "," + chip[1] + "," + chip[2] + "," + chip[3];
                    else
                        newCart += "|" + chip[0] + "," + chip[1] + "," + chip[2] + "," + chip[3];
                    newTotal += decimal.Parse(chip[2]) * decimal.Parse(chip[3]);
                }
            }
            if (productsToRemove.Count != 0)
            {
                isCreated = false;
                OrderStatus.Text = "The following items were removed from your cart because there isn't enough stock: ";
                foreach (int id in productsToRemove)
                    OrderStatus.Text += "</br> - " +  prodRef.Read(id).name + ", " + prodRef.Read(id).stock + " items left in stock";
                if (newTotal == 0)
                {
                    HttpCookie cookie = new HttpCookie("shoppingcart");
                    cookie.Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies.Add(cookie);
                    HttpCookie total = new HttpCookie("carttotal");
                    total.Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies.Add(total);
                    OrderDetails.Text = "Your cart is now empty";
                }
                else
                {
                    Response.Cookies["shoppingcart"].Value = newCart;
                    Response.Cookies["carttotal"].Value = newTotal.ToString();
                    OrderDetails.Text = "Your new total after removing items is " + newTotal.ToString();
                }
            }
            else
                orderRef.Create(CartToOrder());
            return isCreated;
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
                order.items = new List<OrderReference.TOrderItem>();
                string lcookies = Request.Cookies["shoppingcart"].Value;
                string[] cookies = lcookies.Split('|');
                foreach (string cookie in cookies)
                {
                    string[] c = cookie.Split(',');
                    OrderReference.TOrderItem item = new OrderReference.TOrderItem
                    {
                        itemid = 0,
                        productid = int.Parse(c[0]),
                        quantity = int.Parse(c[2]),
                        price = int.Parse(c[2]) * int.Parse(c[3])
                    };
                    order.items.Add(item);
                }
            }
            return order;
        }
    }
}