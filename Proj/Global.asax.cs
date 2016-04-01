using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Proj
{
    public class Global : System.Web.HttpApplication
    {
       static public List<string> data = new List<string>();
        protected void Application_Start(object sender, EventArgs e)
        {
        }
    }
}