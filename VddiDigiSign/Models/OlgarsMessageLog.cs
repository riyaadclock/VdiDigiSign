using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VddiDigiSign.Models
{
    public class OlgarsMessageLog
    {
        public int OlgarsMessageLogId { get; set; }
        public int LeadId { get; set; }
        public int UserId { get; set; }
        public string MessageId { get; set; }
        public string MessageText { get; set; }
        public string MessageTo { get; set; }
        public string MessageStatus { get; set; }
        public string MessageError { get; set; }
        public string MessageCode { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
    }
}
