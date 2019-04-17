using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace domotica_project
{
    public partial class Game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mainmenu(object sender, EventArgs e)
        {
            Response.Redirect("mainMenu.aspx");
        }
    }
}