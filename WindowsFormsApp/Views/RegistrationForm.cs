using System;
using System.Windows.Forms;
using Bll.Interfaces;
using Dto;
using WindowsFormsApp.Infrastructure;

namespace WindowsFormsApp.Views
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRegistrationService _userRegistrationService;

        public RegistrationForm(IUserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var user = new UserDto {
                FirstName = firstNameMaskedTextBox.Text,
                LastName = lastNameMaskedTextBox.Text,
                UserName = userNameMaskedTextBox.Text,
                Password = passwordMaskedTextBox.Text,
                DateOfBirth = dateOfBirthPicker.Value,
                AccountRegistered = DateTime.Now,
                EmailAddress = emailAddressMaskedTextBox.Text,
                MobileNumber = mobileNumberMaskedTextBox.Text,
            };

            if (new Validation(_userRegistrationService).IsValidUserToCreate(user, true)) {
                _userRegistrationService.Register(user);
                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            firstNameMaskedTextBox.Text = String.Empty;
            lastNameMaskedTextBox.Text = String.Empty;
            userNameMaskedTextBox.Text = String.Empty;
            passwordMaskedTextBox.Text = String.Empty;
            dateOfBirthPicker.Value = DateTimePicker.MinimumDateTime;
            emailAddressMaskedTextBox.Text = String.Empty;
            mobileNumberMaskedTextBox.Text = String.Empty;

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
