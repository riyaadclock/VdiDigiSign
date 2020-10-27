using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VddiDigiSign.Models
{
    public class SMSObj
    {
        public string toNumber { get; set; }
        //Client Name
        public string toUser { get; set; }
        public string olgarsUser { get; set; }
        public string olgarsEmail { get; set; }
        public string messageText { get; set; }
    }
}
