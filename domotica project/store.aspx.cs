using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace domotica_project.NewFolder1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MortalKombat(object sender, EventArgs e)
        {
            Response.Redirect("item_1.aspx");
        }

        protected void mainmenu(object sender, EventArgs e)
        {
            Response.Redirect("mainMenu.aspx");
        }
    }
}