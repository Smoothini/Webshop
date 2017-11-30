using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebFormsClient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                StatusLabel.Text = "You are not logged in";
            else
                StatusLabel.Text = Session["user"].ToString() + " is logged in";
        }
    }
}