using System;

namespace Domain.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime AccountRegistered { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
    }
}
