using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace domotica_project.store_items
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void unlock(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('Under Construction')", true);
        }

        protected void store(object sender, EventArgs e)
        {
            Response.Redirect("store.aspx");
        }
    }
}