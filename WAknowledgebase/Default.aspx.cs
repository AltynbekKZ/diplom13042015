using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAknowledgebase.provider;

namespace WAknowledgebase
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionProvider provider = new ConnectionProvider();

            provider.GetQuestionsBySectionId(1);
        }
    }
}