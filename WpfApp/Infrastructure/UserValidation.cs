using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using Bll.Interfaces;
using WpfApp.Models;

namespace WpfApp.Infrastructure
{
    public class UserValidation
    {
        private readonly IUserRegistrationService _userRegistrationService;

        private List<ValidationResult> _validationResults;
        private IAttrValidationService _attrValidationService;

        public UserValidation(IAttrValidationService attrValidationService)
        {
            _attrValidationService = attrValidationService;
            _validationResults = new List<ValidationResult>();
        }

        public UserValidation(IUserRegistrationService userRegistrationService, IAttrValidationService attrValidationService)
        {
            _userRegistrationService = userRegistrationService;
            _attrValidationService = attrValidationService;

            _validationResults = new List<ValidationResult>();
        }

        public bool IsValidUser(User user, bool showErrors)
        {
            if (!_attrValidationService.IsValidModel<User>(user, _validationResults))
            {
                if (showErrors) { MessageBoxShowErrors(_validationResults); }
                return false;
            }
            return true;
        }

        public bool IsValidUserToCreate(User user, bool showErrors)
        {
            if (!ValidateUser(user) || !_attrValidationService.IsValidModel<User>(user, _validationResults))
            {
                if (showErrors) { MessageBoxShowErrors(_validationResults); }
                return false;
            }
            return true;
        }

        private bool ValidateUser(User user)
        {
            if (_userRegistrationService.UserNameExist(user.UserName)) {
                _validationResults.Add(new ValidationResult("This username already exists."));
                return false;
            }
            if (_userRegistrationService.EmailExist(user.EmailAddress)) {
                _validationResults.Add(new ValidationResult("This email address already registered."));
                return false;
            }
            return true;
        }

        private static void MessageBoxShowErrors(List<ValidationResult> validationResults)
        {
            foreach (var error in validationResults)
            {
                MessageBox.Show(error.ErrorMessage);
            }
            validationResults.Clear();
        }

    }
}
