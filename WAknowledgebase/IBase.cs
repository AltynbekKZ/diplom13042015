using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WAknowledgebase.Models;

namespace WAknowledgebase
{
    [ServiceContract] 
    public interface IBase
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<QuestionModel> GetQuestionsBySectionId(int sectionid);
    }
}