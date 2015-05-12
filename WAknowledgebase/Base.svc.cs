using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using WAknowledgebase.Models;
using WAknowledgebase.provider;

namespace WAknowledgebase
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Base : IBase
    {
        // Чтобы использовать протокол HTTP GET, добавьте атрибут [WebGet]. (По умолчанию ResponseFormat имеет значение WebMessageFormat.Json.)
        // Чтобы создать операцию, возвращающую XML,
        //     добавьте [WebGet(ResponseFormat=WebMessageFormat.Xml)]
        //     и включите следующую строку в текст операции:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        

        

        // Добавьте здесь дополнительные операции и отметьте их атрибутом [OperationContract]
        public List<QuestionModel> GetQuestionsBySectionId(int sectionid)
        {
            ConnectionProvider provider = new ConnectionProvider();

            return provider.GetQuestionsBySectionId(sectionid, false);
        }
    }
}
