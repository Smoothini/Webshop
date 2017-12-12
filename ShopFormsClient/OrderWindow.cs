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
    }
}
