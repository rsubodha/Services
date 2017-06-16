using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DBS_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IreedemRewards" in both code and config file together.
    [ServiceContract]
    public interface IreedemRewards
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/DBS_Services/{custID}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]

        // String getRewards(String custID);
        List<String> getRewards(String custID);
    }
}
