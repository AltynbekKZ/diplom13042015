using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WAknowledgebase.Models
{
    [DataContract]
    public class QuestionModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int AuthorId { get; set; }
        [DataMember]
        public int SectionId { get; set; }
        [DataMember]
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



    [DataContract]
    public class AnswerModel
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Created { get; set; }
    }
}
