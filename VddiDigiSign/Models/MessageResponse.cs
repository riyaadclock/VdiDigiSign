using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VddiDigiSign.Models
{
   public class MessageResponse
    {
        public string messageId { get; set; }
        public string messageStatus { get; set; }
        public string messageText { get; set; }
        public string to { get; set; }
        public string errorCode { get; set; }
        public string error { get; set; }
        public string errorDescription { get; set; }
    }
}
