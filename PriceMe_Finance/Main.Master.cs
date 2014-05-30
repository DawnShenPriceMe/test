using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace EasyRate
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AddCssAndJs();
            SetActiveNav();
        }

        public void SetMetaKeywordsAndMetaDescription(string metaKeywords, string metaDescription)
        {
            HtmlMeta desc = new HtmlMeta();
            desc.Name = "description";
            desc.Content = metaDescription;
            this.Page.Header.Controls.Add(desc);

            HtmlMeta keywords = new HtmlMeta();
            keywords.Name = "keywords";
            keywords.Content = metaKeywords;
            this.Page.Header.Controls.Add(keywords);
        }

        public void AddCanonical(string canonicalUrl)
        {
            HtmlLink canonicalLink = new HtmlLink();
            canonicalLink.Href = "http://www.priceme.co.nz/money" + canonicalUrl;
            canonicalLink.Attributes.Add("rel", "canonical");
            this.Page.Header.Controls.Add(canonicalLink);
        }

        private void AddCssAndJs()
        {
            HtmlLink cssLink = new HtmlLink();
            cssLink.Href = "css/allRates.css?v=" + ConfigurationManager.AppSettings["cssVersion"];
            cssLink.Attributes.Add("rel", "stylesheet");
            cssLink.Attributes.Add("type", "text/css");
            this.Page.Header.Controls.Add(cssLink);

            cssLink = new HtmlLink();
            cssLink.Href = "css/jquery-ui-1.8.18-priceme.css?v=" + ConfigurationManager.AppSettings["cssVersion"];
            cssLink.Attributes.Add("rel", "stylesheet");
            cssLink.Attributes.Add("type", "text/css");
            this.Page.Header.Controls.Add(cssLink);

            HtmlGenericControl scriptHtmlControl = new HtmlGenericControl("script");
            scriptHtmlControl.Attributes.Add("src", "js/jquery.js?v=" + ConfigurationManager.AppSettings["cssVersion"]);
            scriptHtmlControl.Attributes.Add("type", "text/javascript");
            this.Page.Header.Controls.Add(scriptHtmlControl);

            scriptHtmlControl = new HtmlGenericControl("script");
            scriptHtmlControl.Attributes.Add("src", "js/main.js?v=" + ConfigurationManager.AppSettings["cssVersion"]);
            scriptHtmlControl.Attributes.Add("type", "text/javascript");
            this.Page.Header.Controls.Add(scriptHtmlControl);

            scriptHtmlControl = new HtmlGenericControl("script");
            scriptHtmlControl.Attributes.Add("src", "js/jquery-ui-1.8.18-priceme.js?v=" + ConfigurationManager.AppSettings["cssVersion"]);
            scriptHtmlControl.Attributes.Add("type", "text/javascript");
            this.Page.Header.Controls.Add(scriptHtmlControl);
        }

        private void SetActiveNav()
        {
            string page = this.ContentPlaceHolder1.Page.GetType().ToString().ToLower();//取出内容页面的类型名称
            if (page.Contains("creditcard"))//根据不同的内容页面设置当前选中菜单项
            {
                TopNavigation.menu = "Money";
            }
            else if (page.Contains("savingsaccount"))
            {
                TopNavigation.menu = "SavingsAccount";
            }
            else if (page.Contains("termdeposit"))
            {
                TopNavigation.menu = "TermDeposit";
            }
            else if (page.Contains("homeloan"))
            {
                TopNavigation.menu = "HomeLoans";
            }
            else if (page.Contains("kiwisaver"))
            {
                TopNavigation.menu = "KiwiSaver";
            }
        }
    }
}