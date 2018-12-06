using System;
using System.ComponentModel.DataAnnotations;
using WpfApp.ViewModels.Abstract;

namespace WpfApp.Models
{
    public class User : NotifyPropertyChangedHelper, ICloneable
    {
        #region Fields

        private long _userId;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _password;
        private DateTime _accountRegistered;
        private string _emailAddress;

        #endregion

        #region Binding Properties

        public long UserId {
            get => _userId;
            set => SetField(ref _userId, value);
        }

        [DataType(DataType.Text, ErrorMessage ="Enter only alphabetical data.")]
        [StringLength(30, ErrorMessage = "First name should be a maximum of 30 chaaracters.")]
        public string FirstName {
            get => _firstName;
            set => SetField(ref _firstName, value);
        }

        [DataType(DataType.Text, ErrorMessage = "Enter only alphabetical data.")]
        [StringLength(30, ErrorMessage = "Last name should be a maximum of 30 chaaracters.")]
        public string LastName {
            get => _lastName;
            set => SetField(ref _lastName, value);
        }

        [Required(ErrorMessage ="UserName is required.")]
        [StringLength(20, ErrorMessage ="User name should be a maximum of 20 chaaracters.")]
        public string UserName {
            get => _userName;
            set => SetField(ref _userName, value);
        }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password should be a maximum of 50 chaaracters.")]
        public string Password {
            get => _password;
            set => SetField(ref _password, value);
        }

        public DateTime AccountRegistered {
            get => _accountRegistered;
            set => SetField(ref _accountRegistered, value);
        }

        [DataType(DataType.EmailAddress, ErrorMessage ="Enter valid email address.")]
        [StringLength(40, ErrorMessage = "Email address should be a maximum of 40 chaaracters.")]
        public string EmailAddress {
            get => _emailAddress;
            set => SetField(ref _emailAddress, value);
        }

        #endregion

        public object Clone()
        {
            return (User)this.MemberwiseClone();
        }
    }
}
