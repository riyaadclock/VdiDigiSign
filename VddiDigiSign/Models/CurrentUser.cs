using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VddiDigiSign.Models
{
    class CurrentUser
    {
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserPassword { get; set; }
        public string UserTitle { get; set; }
        public string ProfilePic { get; set; }
        public string AuthenticationType { get; set; }
        public int SignioDetailId { get; set; }
    }
}
