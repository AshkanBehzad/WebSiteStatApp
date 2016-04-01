using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
namespace Proj
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool authCheck = (HttpContext.Current.User != null) && HttpContext.Current.User.Identity.IsAuthenticated;
            if (!authCheck)
                Response.Redirect("~\\Account\\Login.aspx");
            else
                Response.Redirect("~\\Admin\\Default.aspx");
        }
    }
}