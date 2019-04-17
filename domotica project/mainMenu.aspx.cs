using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace domotica_project
{
    public partial class mainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gam(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Game.aspx");
        }

        protected void house(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("http://localhost:60088/DomoticaInterface.aspx");
            Response.Redirect("~/domotica/dominterface.aspx");
        }

        protected void cons(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("store.aspx");
        }

        protected void desp(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("http://localhost:50613/WebForm1.aspx#");
        }
    }
}