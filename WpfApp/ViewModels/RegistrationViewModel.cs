using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Bll.Interfaces;
using WpfApp.Infrastructure;
using WpfApp.Models;
using WpfApp.ViewModels.Abstract;

namespace WpfApp.ViewModels
{
    public class RegistrationViewModel : NotifyPropertyChangedHelper
    {
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly IAttrValidationService _attrValidationService;

        private ICommand _registerCommand;

        #region Fields

        private User _user;
        #endregion

        #region Binding members

        public User User {
            get => _user;
            set => SetField(ref _user, value);
        }
        #endregion

        public RegistrationViewModel(IUserRegistrationService userRegistrationService, IAttrValidationService attrValidationService)
        {
            _userRegistrationService = userRegistrationService;
            _attrValidationService = attrValidationService;

            _user = new User();
        }

        private void ResetUserData()
        {
            User.FirstName = String.Empty;
            User.LastName = String.Empty;
            User.Password = String.Empty;
            User.UserName = String.Empty;
            User.EmailAddress = String.Empty;
        }

        public ICommand RegisterCommand
        {
            get => _registerCommand ?? (_registerCommand = new RelayCommand(obj =>
            {
                if (new UserValidation(_userRegistrationService, _attrValidationService).IsValidUserToCreate(User, true)) {
                    _userRegistrationService.Register(Mapper.Map(User));
                    ResetUserData();
                    MessageBox.Show("User Successfully Registered !");
                }
            }));
        }
    }
}
