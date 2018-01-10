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
        OrderReference.IOrder orderRef;
        ProductReference.IProduct prodRef;
        TOrder selected_order;
        TOrderItem selected_item;
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void OrderWindow_Load(object sender, EventArgs e)
        {
            orderRef = new OrderReference.OrderClient();
            prodRef = new ProductReference.ProductClient();
            selected_order = new TOrder();
            selected_item = new TOrderItem();
            refreshButton.PerformClick();
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersBox.SelectedItem != null)
                if (orderRef.Delete(selected_order))
                    statusLabel.Text = "Order successfully deleted";
                else
                    statusLabel.Text = "Error deleting order";
            refreshButton.PerformClick();
        }

        private void markDeliveredButton_Click(object sender, EventArgs e)
        {
            if (ordersBox.SelectedItem != null)
                if (orderRef.MarkDelivery(selected_order))
                    statusLabel.Text = "Order successfully marked as delivered";
                else
                    statusLabel.Text = "Error marking the order";
            refreshButton.PerformClick();
        }

        private void ordersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if(ordersBox.SelectedItem!=null)
            {
                selected_order = (TOrder)ordersBox.SelectedItem;
                foreach (TOrderItem item in selected_order.items)
                    items += item.quantity + " " + prodRef.Read(item.productid).name + ", ";
                orderItems.Text = items;
                userLabel.Text = selected_order.userid.ToString();
                addressLabel.Text = selected_order.userid.ToString();
                priceLabel.Text = selected_order.price.ToString();
                dateLabel.Text = selected_order.date;
                if (selected_order.isDelivered)
                    isDelivered.Checked = true;
                else
                    isDelivered.Checked = false;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ordersBox.DataSource = null;
            ordersBox.DataSource = orderRef.ReadAll();
        }
        
    }
}
