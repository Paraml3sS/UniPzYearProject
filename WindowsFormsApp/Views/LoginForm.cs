using System;
using System.Windows.Forms;
using Bll.Interfaces;
using WindowsFormsApp.Infrastructure;

namespace WindowsFormsApp.Views
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly RegistrationForm _registrationForm;

        public LoginForm(IAuthenticationService authenticationService, IUserRegistrationService userRegistrationService)
        {
            _authenticationService = authenticationService;
            _userRegistrationService = userRegistrationService;
            _registrationForm = new RegistrationForm(_userRegistrationService);
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //string[] adminCredentials = new string[] { "Ololo", "NotPlainAnymore" };
            //string[] userCredentials = new string[] { "Korol", "12345" };

            if (_authenticationService.Login(/*"Ololo", "NotPlainAnymore"*/this.userNameBox.Text, this.passwordBox.Text)) {
                LoginInfo.UserName = /*"Ololo";*/this.userNameBox.Text;
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("Enter valid credentials.");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_registrationForm.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            } else {
                MessageBox.Show("Your account successfully registered !");
                this.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
