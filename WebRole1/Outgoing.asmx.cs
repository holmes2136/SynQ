using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebRole1
{
    /// <summary>
    /// Summary description for Outgoing
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Outgoing : System.Web.Services.WebService, ICompassOutgoingWebServicePortBinding
    {

        public orderPickConfirmationMessageResponse orderPickConfirmation(cpOrderPickConfirmationMessageRequest orderPickConfirmationMessageRequest)
        {
            orderPickConfirmationMessageResponse response = new orderPickConfirmationMessageResponse();

            messageHeader header = new messageHeader();
            header = new messageHeader();
            header.version = "1.0";
            header.msgId = "134324";
            header.msgType = "OrderMaster";
            header.transCode = "NEW";
            header.sender = "Compass";
            header.receiver = "SynQ";
            header.msgTime = DateTime.Now;
            header.msgTimeSpecified = true;
            response.messageHeader = header;

            response.messageError = new messageError()
            {
                code = 112,
                message = "test",
                codeSpecified = true
            };
            return response;
        }

        public orderStatusChangeNotificationMessageResponse orderStatusChangeNotification(orderStatusChangeNotificationMessageRequest orderStatusChangeNotificationMessageRequest)
        {
            orderStatusChangeNotificationMessageResponse response = new orderStatusChangeNotificationMessageResponse();
            messageHeader header = new messageHeader();
            header = new messageHeader();
            header.version = "1.0";
            header.msgId = "134324";
            header.msgType = "OrderMaster";
            header.transCode = "NEW";
            header.sender = "Compass";
            header.receiver = "SynQ";
            header.msgTime = DateTime.Now;
            header.msgTimeSpecified = true;
            response.messageHeader = header;

            response.messageError = new messageError()
            {
                code = 112,
                codeSpecified = true,
                message = "test"
            };
            return response;
        }
    }
}
