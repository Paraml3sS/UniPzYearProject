using System;
using System.Windows.Forms;
using Bll.Interfaces;
using Dto;
using WindowsFormsApp.Infrastructure;

namespace WindowsFormsApp.Views
{
    public partial class UpdateUserForm : Form
    {
        private readonly IAdminService<UserDto> _adminService;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly UserDto _user;

        public UpdateUserForm(IAdminService<UserDto> adminService, IUserRegistrationService userRegistrationService, UserDto user)
        {
            _user = user;
            _adminService = adminService;
            _userRegistrationService = userRegistrationService;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            _user.FirstName = firstNameMaskedTextBox.Text;
            _user.LastName = lastNameMaskedTextBox.Text;
            _user.UserName = userNameMaskedTextBox.Text;
            if (passwordMaskedTextBox.Text != String.Empty) { _user.Password = _userRegistrationService.GetHash(passwordMaskedTextBox.Text); }
            _user.EmailAddress = emailAddressMaskedTextBox.Text;
            _user.MobileNumber = mobileNumberMaskedTextBox.Text;            

            if (Validation.IsValidModel(_user, true)) {
                _adminService.Update(_user.UserId, _user);
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            firstNameMaskedTextBox.Text = _user.FirstName;
            lastNameMaskedTextBox.Text = _user.LastName;
            userNameMaskedTextBox.Text = _user.UserName;
            emailAddressMaskedTextBox.Text = _user.EmailAddress;
            mobileNumberMaskedTextBox.Text = _user.MobileNumber;
        }
    }
}
