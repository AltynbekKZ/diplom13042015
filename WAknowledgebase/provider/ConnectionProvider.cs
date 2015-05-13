using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAknowledgebase.Controllers;
using WAknowledgebase.Models;

namespace WAknowledgebase.provider
{
    public class ConnectionProvider : DataAccess
    {
        public List<QuestionModel> GetQuestionsBySectionId(int id, bool onlyNew)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("proc_GetQuetionBySectionId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sectionid", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@onlyNew", SqlDbType.Int).Value = onlyNew;
                cn.Open();

                IDataReader reader = ExecuteReader(cmd);

                return QuestionModel.GetQuestionsFromReader(reader);
            }
        }

        public List<AnswerModel> GetReplies()
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Reply_GetAllReplies", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                IDataReader reader = ExecuteReader(cmd);

                return AnswerModel.GetAnswersFromReader(reader);
            }
        }

        public void InsertReplyByQuestionId(int questionid, int authorid, string title, string description)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertReplyByQuestionId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                cmd.Parameters.Add("@autorid", SqlDbType.Int).Value = authorid;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value= description;
                cmd.Parameters.Add("@qid", SqlDbType.Int).Value= questionid;
                cn.Open();
                ExecuteReader(cmd);
            }
        }

        public void InsertQuestion(int sectionid, int authorid, string title)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertQuestion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                cmd.Parameters.Add("@autorid", SqlDbType.Int).Value = authorid;
                cmd.Parameters.Add("@sectionid", SqlDbType.VarChar).Value = sectionid;
                cn.Open();
                ExecuteReader(cmd);
            }
        }


        public void ConnectQuestionWithReply(int questionid, int replyid)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertConnection", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@questionid", SqlDbType.Int).Value = questionid;
                cmd.Parameters.Add("@replyid", SqlDbType.Int).Value = replyid;
                cn.Open();
                ExecuteReader(cmd);
            }
        }

        public List<AnswerModel> GetAnswerByQuestionId(int id)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Reply_GetReplyByQuestionId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@questionid", SqlDbType.Int).Value = id;
                cn.Open();

                IDataReader reader = ExecuteReader(cmd);

                var questions = new List<AnswerModel>();
                questions = AnswerModel.GetAnswersFromReader(reader);
               
                return questions;
            }
        }
    }
}
