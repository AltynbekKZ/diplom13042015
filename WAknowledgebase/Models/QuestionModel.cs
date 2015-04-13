using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAknowledgebase.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int SectionId { get; set; }
        public DateTime Created { get; set; }


        public static List<QuestionModel> GetQuestionsFromReader(IDataReader reader)
        {
            var questions = new List<QuestionModel>();
            while (reader.Read())
            {
                questions.Add(new QuestionModel
                {
                    Id = (int) reader["id"],
                    AuthorId = (int)reader["authorid"],
                    SectionId = (int)reader["sectionid"],
                    Created = (DateTime)reader["created"],
                    Title = reader["title"].ToString()
                });
            }
            return questions;
        }
    }
}
