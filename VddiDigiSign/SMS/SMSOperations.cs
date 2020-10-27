using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VddiDigiSign.SMS
{
    public class SMSOperations
    {
        public static string CallClickATell(string Token, string json)
        {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://platform.clickatell.com/messages");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.PreAuthenticate = true;
            httpWebRequest.Headers.Add("Authorization", Token);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }


            try
            {

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string currentMessage = "";
                currentMessage = ex.Message.ToString();
            }

            return "";
        }
        
        //This function is in charge of converting the data into a json array and sending it to the rest sending controller.
        public static string SendSMS(int leadId,string Token, Dictionary<string, string> Params)
        {
            Params["to"] = CreateRecipientList(Params["to"]);
            string JsonArray = JsonConvert.SerializeObject(Params, Formatting.None);
            JsonArray = JsonArray.Replace("\\\"", "\"").Replace("\"[", "[").Replace("]\"", "]");

            string errMesg = "";
            Models.MessageResponse mesgResponse = new Models.MessageResponse();
             
            string ReturnBody = CallClickATell(Token, JsonArray);

            var rootObject = JsonConvert.DeserializeObject<ClickAtellResponse>(ReturnBody);

            if (rootObject != null)
            { 
                string apiMessage = rootObject.messages[0].apiMessageId;
                string errorCode = "";
                string errorDesc = "";

                if (apiMessage == null)
                {
                    apiMessage = "Error Response from Service Provider";
                }

                mesgResponse.messageId = apiMessage;
                mesgResponse.messageText = Params["content"].ToString();
                mesgResponse.to = Params["to"].ToString();


                if (rootObject.messages[0].errorCode != null)
                {
                    errorCode = rootObject.messages[0].errorCode.ToString();
                }

                mesgResponse.errorCode = errorCode;
                
                if (rootObject.messages[0].errorDescription != null)
                {
                    errorDesc = rootObject.messages[0].errorDescription.ToString();
                }

                mesgResponse.errorDescription = errorDesc;
                mesgResponse.error = errorDesc;
                


                string errStatus = rootObject.messages[0].accepted.ToString();
                mesgResponse.messageStatus = errStatus;

                errMesg = apiMessage + " " + errorCode + " " + errorDesc + " " + errStatus;
            }
            else
            {
                mesgResponse.messageId = "error";
                mesgResponse.errorCode = "error";
                mesgResponse.errorDescription = "error";
                mesgResponse.error = "error";
                mesgResponse.messageStatus = "error";
                mesgResponse.messageText = Params["content"].ToString();
                mesgResponse.to = Params["to"].ToString();

            }

            Controllers.MessageOperations msgOps = new Controllers.MessageOperations();
            msgOps.addLog(mesgResponse, leadId);

            return errMesg;
        }

        //This function converts the recipients list into an array string so it can be parsed correctly by the json array.
        public static string CreateRecipientList(string to)
        {
            string[] tmp = to.Split(',');
            to = "[\"";
            to = to + string.Join("\",\"", tmp);
            to = to + "\"]";
            return to;
        }

        public class Message
        {
            public string apiMessageId { get; set; }
            public bool accepted { get; set; }
            public string to { get; set; }
            public object errorCode { get; set; }
            public object error { get; set; }
            public object errorDescription { get; set; }
        }

        public class ClickAtellResponse
        {
            public List<Message> messages { get; set; }
            public object errorCode { get; set; }
            public object error { get; set; }
            public object errorDescription { get; set; }
        }
    }
}