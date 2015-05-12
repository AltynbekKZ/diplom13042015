using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAknowledgebase.Models;
using WAknowledgebase.provider;

namespace WAknowledgebase
{
    public partial class AddReplyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillQuestions();
                FillReplies();
            }
        }
        private int authorid = 1;
        private void FillQuestions()
        {
            ConnectionProvider provider = new ConnectionProvider();
            ddlQuestion.Items.Clear();
            foreach (QuestionModel question in provider.GetQuestionsBySectionId(int.Parse(ddlSection.SelectedValue), cbOnlyNewQuestions.Checked))
            {
                ddlQuestion.Items.Add(new ListItem(question.Title + "...", question.Id.ToString()));
            }
            lbQuestionText.Text = ddlQuestion.SelectedItem.Text;
        }


        private void FillReplies()
        {
            ConnectionProvider provider = new ConnectionProvider();
            ddlRepliesList.Items.Clear();
            foreach (AnswerModel reply in provider.GetReplies())
            {
                ddlRepliesList.Items.Add(new ListItem(reply.Title, reply.Id));
            }
            lbReplyText.Text = ddlRepliesList.SelectedItem.Text;
        }
        protected void cbOnlyNewQuestions_CheckedChanged(object sender, EventArgs e)
        {
            FillQuestions();
        }

        protected void btnAddNewReply_Click(object sender, EventArgs e)
        {
            ConnectionProvider provider = new ConnectionProvider();
            provider.InsertReplyByQuestionId(int.Parse(ddlQuestion.SelectedValue), authorid, tbReplyText.InnerText, tbDescription.Text);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "openwindow", "alert('Жауап қосылды');", true);
            Page.Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);
        }

        protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillQuestions();
        }

        protected void ddlQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbQuestionText.Text = ddlQuestion.SelectedItem.Text;
        }

        protected void ddlRepliesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbReplyText.Text = ddlRepliesList.SelectedItem.Text;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);
        }

        protected void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionProvider provider = new ConnectionProvider();
            provider.ConnectQuestionWithReply(int.Parse(ddlQuestion.SelectedValue), int.Parse(ddlRepliesList.SelectedValue));
            Page.Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);
        }
    }
}