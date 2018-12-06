using System;
using System.ComponentModel.DataAnnotations;

namespace Dto
{
    public class UserDto
    {
        public long UserId { get; set; }

        [DataType(DataType.Text, ErrorMessage ="Enter only alphabetical data.")]
        [StringLength(30, ErrorMessage = "First name should be a maximum of 30 chaaracters.")]
        public string FirstName { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Enter only alphabetical data.")]
        [StringLength(30, ErrorMessage = "Last name should be a maximum of 30 chaaracters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="UserName is required.")]
        [StringLength(20, ErrorMessage ="User name should be a maximum of 20 chaaracters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password should be a maximum of 50 chaaracters.")]
        public string Password { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="Enter valid date.")]
        public DateTime? DateOfBirth { get; set; }
        public DateTime AccountRegistered { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Enter valid email address.")]
        [StringLength(40, ErrorMessage = "Email address should be a maximum of 40 chaaracters.")]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Enter valid phone number.")]
        [StringLength(13, ErrorMessage = "Phone number should be a maximum of 13 chaaracters.")]
        public string MobileNumber { get; set; }
    }
}
