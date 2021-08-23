using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wba.RekenSommen.Web
{
    public partial class Rekenen : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mnuOptellen.Attributes["class"] = "nav-item";
            mnuDelen.Attributes["class"] = "nav-item";
            mnuAftrekken.Attributes["class"] = "nav-item";
            mnuVermenigvuldigen.Attributes["class"] = "nav-item";

            string pageName = this.Page.Request.FilePath.ToUpper();
            if (pageName == "/DEFAULT.ASPX")
            {
                mnuOptellen.Attributes["class"] = "nav-item active";
            }
            else if (pageName == "/VERSCHIL.ASPX")
            {
                mnuAftrekken.Attributes["class"] = "nav-item active";
            }
            else if (pageName == "/DELEN.ASPX")
            {
                mnuDelen.Attributes["class"] = "nav-item active";
            }
            else 
            {
                mnuVermenigvuldigen.Attributes["class"] = "nav-item active";
            }
        }
    }
}