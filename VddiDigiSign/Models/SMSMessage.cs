using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VddiDigiSign.Models
{
    public class SMSMessage
    {
        public int MsgTextListId { get; set; }
        public int ApplicationStatusId { get; set; }
        public string EventId { get; set; }
        public string MsgText { get; set; }
        public string RecieverId { get; set; }
        public int SysStatus { get; set; }
        public string ParamType { get; set; }
    }
}
