using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace VddiDigiSign.Controllers
{
    public class SMSMessageOperations
    {
        Controllers.SettingsOperations settingOps = new Controllers.SettingsOperations();

        public string swapText(Models.SMSObj smsDetails, string thisText, string paramType)
        {
            string newText = "";

            switch (paramType)
            {
                case "1":
                    StringBuilder emailBuilder = new StringBuilder(thisText);
                    emailBuilder.Replace("{0}", smsDetails.olgarsEmail);
                    newText = emailBuilder.ToString();
                    break;
                case "2":
                    StringBuilder builder = new StringBuilder(thisText);
                    builder.Replace("{0}", smsDetails.olgarsUser);
                    builder.Replace("{1}", smsDetails.toUser);
                    newText = builder.ToString();
                    break;
                case "3":
                    StringBuilder clientBuilder = new StringBuilder(thisText);
                    clientBuilder.Replace("{0}", smsDetails.toUser);
                    newText = clientBuilder.ToString();
                    break;
                case "4":
                    StringBuilder declineEmailBuilder = new StringBuilder(thisText);
                    declineEmailBuilder.Replace("{0}", smsDetails.toUser);
                    declineEmailBuilder.Replace("{1}", smsDetails.messageText);
                    newText = declineEmailBuilder.ToString();
                    break;
                case "5":
                    StringBuilder declineBrokerEmailBuilder = new StringBuilder(thisText);
                    declineBrokerEmailBuilder.Replace("{0}", smsDetails.olgarsUser);
                    declineBrokerEmailBuilder.Replace("{1}", smsDetails.toUser);
                    declineBrokerEmailBuilder.Replace("{2}", smsDetails.messageText);
                    newText = declineBrokerEmailBuilder.ToString();
                    break;
                default:
                    newText = smsDetails.messageText;
                    break;
            }

            return newText;

        }


        //Read from list using event id
        public Models.MsgTextList getMsgText(string eventId,string recieverId)
        {
            Models.MsgTextList msgText = new Models.MsgTextList();
             var sql = "";

            var db = new PetaPoco.Database("Olgarsconnection");

            
            sql = "Select top 1 * from MsgTextList " + " Where [EventId] = '" + eventId + "' AND [RecieverId] = '" + recieverId + "' ";

            msgText = db.SingleOrDefault<Models.MsgTextList>(sql);

            return msgText;
        }


        //Tie to SMS Class
        public string sendSMSMessage(Models.SMSObj smsDetails,string eventId,string leadId,int recieverSwitch)
        {
            //recieverSwitch
            //1=Client
            //2=Broker

            //Param Type
            //0 = None
            //1 = Email Address of Olgars User
            //2 = Both User and Broker

            List<string> SendSMSWithSalesManagerDetails = new List<string>();
            SendSMSWithSalesManagerDetails.Add("After_Signio");
            SendSMSWithSalesManagerDetails.Add("Approved_Not_Taken");
            SendSMSWithSalesManagerDetails.Add("Pre_Signio_Document_Request");
            SendSMSWithSalesManagerDetails.Add("Self_Employed");

            string msgResponse = "";
            string smsApi = settingOps.getValue("SMSApi");
            Models.MsgTextList msgText = new Models.MsgTextList();

            string messageText = "";
            string recieverId = "";

            if (recieverSwitch == 1)
            {
                recieverId = "Client";
            }
            else
            {
                recieverId = "Broker";
            }

            //Go replace the message
            if (smsDetails.messageText == "")
            {
                msgText = getMsgText(eventId, recieverId);

                if (msgText.ParamType == "0")
                {
                    messageText = msgText.MsgText;
                }
                else
                {
                    messageText = swapText(smsDetails, msgText.MsgText, msgText.ParamType);

                    if (messageText == "" || messageText == null)
                    {
                        messageText = "";
                    }
                }

            }
            else
            {
                msgText = getMsgText(eventId, recieverId);
                if (msgText.ParamType == "0")
                {
                    messageText = msgText.MsgText;
                }
                else
                {
                    messageText = swapText(smsDetails, msgText.MsgText, msgText.ParamType);
                    if (messageText == "" || messageText == null)
                    {
                        messageText = "";
                    }
                }

            }

            //Final Message check for either Sales Manager or Application Specialist
            foreach(string smsType in SendSMSWithSalesManagerDetails)
            {
                if(eventId == smsType)
                {
                    //Controllers.SalesLinkOperations salesLinkOps = new Controllers.SalesLinkOperations();
                    string SalesManager = "", AppSpecialist = "";

                    //SalesManager = salesLinkOps.getSalesExecEmail(leadId);
                    //AppSpecialist = salesLinkOps.getApplicationSpecialistEmail(leadId);
                    SalesManager = "1";
                    AppSpecialist = "2";

                    if (AppSpecialist != null)
                    {
                        if (AppSpecialist.Length > 2)
                        {
                            messageText = messageText + Environment.NewLine + "Application Specialist: " + AppSpecialist;
                        }
                    }


                    if (SalesManager != null)
                    {
                        if (SalesManager.Length > 2)
                        {
                            messageText = messageText + Environment.NewLine + "Sales Manager: " + SalesManager;
                        }
                    }

                }
            }
          
               
           
            //Close off the Message

            //Now send the actual message
            Dictionary<string, string> Params = new Dictionary<string, string>();

            //adding the parameters to the dictionary
            Params.Add("content", messageText);
            Params.Add("to", smsDetails.toNumber);
            int thisLeadId = Convert.ToInt32(leadId);

            if (smsApi != "")
            {
                msgResponse = SMS.SMSOperations.SendSMS(thisLeadId, smsApi, Params);
            }


            return msgResponse;


        }

        public string sendManualSMSMessage(Models.SMSObj smsDetails, string leadId,int runType)
        {
                    
            string msgResponse = "";
            string smsApi = settingOps.getValue("SMSApi");
            Models.MsgTextList msgText = new Models.MsgTextList();

            if (runType == 1)
            {
                msgText = getMsgText("BirthDay_Message", "Client");
            }
            else
            {
                msgText.MsgText = smsDetails.messageText;
            }
            


            string messageText = ""; //smsDetails.messageText;

            messageText = smsDetails.messageText; //swapText(smsDetails, msgText.MsgText, "1");


            //Now send the actual message
            Dictionary<string, string> Params = new Dictionary<string, string>();

            //adding the parameters to the dictionary
            Params.Add("content", messageText);
            Params.Add("to", smsDetails.toNumber);
            int thisLeadId = Convert.ToInt32(leadId);

            if (smsApi != "")
            {
                msgResponse = SMS.SMSOperations.SendSMS(thisLeadId, smsApi, Params);
            }


            return msgResponse;
        }
      
    }
}