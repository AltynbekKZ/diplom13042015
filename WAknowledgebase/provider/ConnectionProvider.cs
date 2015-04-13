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
        public List<QuestionModel> GetQuestionsBySectionId(int id)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("proc_GetQuetionBySectionId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sectionid", SqlDbType.Int).Value = id;
                cn.Open();

                IDataReader reader= ExecuteReader(cmd);

                return QuestionModel.GetQuestionsFromReader(reader);
            }
        }
    }
}
