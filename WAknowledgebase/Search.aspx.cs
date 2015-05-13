using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAknowledgebase.provider;

namespace WAknowledgebase
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            new ConnectionProvider().InsertQuestion(int.Parse(ddlSection.SelectedItem.Value), 2,
                taQuestionText.InnerText);
            Page.Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Page.Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);
        }
    }
}