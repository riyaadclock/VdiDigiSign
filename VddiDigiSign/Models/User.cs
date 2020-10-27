using System;

namespace VddiDigiSign.Models
{
    class User
    {
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public int BrokerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string HomeNumber { get; set; }
        public string EmailAddress { get; set; }
        public string UserPassword { get; set; }
        public string UserTitle { get; set; }
        public string ProfilePic { get; set; }
        public string AuthenticationType { get; set; }
        public DateTime SignUpDate { get; set; }
        public string googleID { get; set; }
        public bool SysStatus { get; set; }
        public string AddedBy { get; set; }
        public int DeleteSTatus { get; set; }
    }
}
