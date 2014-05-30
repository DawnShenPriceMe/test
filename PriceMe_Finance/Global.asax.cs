using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AllRates
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.HttpMethod == "POST")
            {
                return;
            }

            string currentUrl = HttpContext.Current.Request.RawUrl;
            string applicationPath = HttpContext.Current.Request.ApplicationPath;
            string url = AllRates.Logic.UrlController.GetRealUrl(applicationPath, currentUrl);
            HttpContext.Current.RewritePath(url, false);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            if (ex is HttpRequestValidationException)
            {
                Response.ClearContent();
                Response.Write("<h3>HTML tags are not allowed. Please only use text.</h3>");
                Response.Write("<br /><input type='button' onclick='javascript:history.go(-1);' value='Go back'>");
                Server.ClearError();
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}