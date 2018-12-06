using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bll.Interfaces;
using Dto;
using WindowsFormsApp.Infrastructure;

namespace WindowsFormsApp.Views
{
    public partial class UserListForm : Form
    {
        private readonly IAdminService<UserDto> _adminService;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly IAuthorizationService _authorizationService;

        public UserListForm(IAdminService<UserDto> adminService, IUserRegistrationService userRegistrationService, IAuthorizationService authorizationService)
        {
            _adminService = adminService;
            _userRegistrationService = userRegistrationService;
            _authorizationService = authorizationService;
            
            dataGridView = new DataGridView();
            bindingNav = new BindingNavigator();
            bindingSource = new BindingSource();
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _adminService.Get();
            bindingNav.BindingSource = bindingSource;
            dataGridView.DataSource = bindingSource;

            if(_authorizationService.GetUserRoles(LoginInfo.UserName).Where(ur => ur.RoleId == 1).FirstOrDefault() != null) {
                bindingNav.Visible = true;
            }
        }

        private void updateRowButton_Click(object sender, FilterEventArgs e)
        {

            var user = (UserDto)this.bindingSource.Current;

            if (!String.IsNullOrEmpty(user.UserName)) {
                new UpdateUserForm(_adminService, _userRegistrationService, user).Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var user = (UserDto)this.bindingSource.Current;

            _adminService.Delete(user.UserId);
            bindingSource.Remove(user);
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            bindingSource.DataSource = _adminService.Get();
        }

        private void promoteToAdmin_Click(object sender, EventArgs e)
        {
            var user = (UserDto)this.bindingSource.Current;

            _adminService.AddUserRole(user.UserId, 1);
            _adminService.DeleteUserRole(user.UserId, 5);
        }

        private void promoteToUser_Click(object sender, EventArgs e)
        {
            var user = (UserDto)this.bindingSource.Current;

            _adminService.AddUserRole(user.UserId, 5);
            _adminService.DeleteUserRole(user.UserId, 1);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void firstNameSortButton_Click(object sender, EventArgs e)
        {
            var data = (List<UserDto>)bindingSource.DataSource;
            bindingSource.DataSource = data.OrderBy(u => u.FirstName).ToList();
        }

        private void accountRegisteredSortButton_Click(object sender, EventArgs e)
        {
            var data = (List<UserDto>)bindingSource.DataSource;
            bindingSource.DataSource = data.OrderBy(u => u.AccountRegistered).ToList();
        }
    }
}
