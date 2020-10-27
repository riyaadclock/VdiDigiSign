using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VddiDigiSign.Controllers
{
    public class MessageOperations
    {

        public int addLog(Models.MessageResponse thisMessage, int leadId)
        {
            int leadLogId = -1;

            Models.OlgarsMessageLog appLog = new Models.OlgarsMessageLog();
         

            appLog.LeadId = leadId;
            appLog.UserId = 0;
            appLog.DateAdded = DateTime.Now;
            appLog.AddedBy = "Server Notify Job";

            //Now the passed items
            appLog.MessageCode = thisMessage.errorCode;
            appLog.MessageError = thisMessage.error;
            appLog.MessageStatus = thisMessage.messageStatus;
            appLog.MessageId = thisMessage.messageId;
            appLog.MessageTo = thisMessage.to;
            appLog.MessageText = thisMessage.messageText;

            leadLogId = addMessageLog(appLog);


            return leadLogId;
        }


        public int addMessageLog(Models.OlgarsMessageLog newMessageLog)
        {
            int leadLogId = -1;

            var db = new PetaPoco.Database("Olgarsconnection");
            db.Insert("OlgarsMessageLog", "OlgarsMessageLogId", true, newMessageLog);
            leadLogId = newMessageLog.OlgarsMessageLogId;

            return leadLogId;
        }
    }
}