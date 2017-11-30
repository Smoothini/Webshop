using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopService.Transporter;

namespace ShopFormsClient
{
    public partial class OrderWindow : Form
    {
        OrderReference.IOrder order;
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order = new OrderReference.OrderClient();
            TOrder t = new TOrder
            {
                orderid = 0,
                userid = 2020,
                date = "asdsdf",
                isDelivered = false,
                price = 200
            };
                if (order.Create(t))
                    button1.Text = "Success";
                else
                    button1.Text = "bag pl";
        }
    }
}
