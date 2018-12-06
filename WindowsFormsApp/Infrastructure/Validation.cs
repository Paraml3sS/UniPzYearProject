using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Bll.Interfaces;
using Dto;

namespace WindowsFormsApp.Infrastructure
{
    public class Validation
    {
        private static IUserRegistrationService _userRegistrationService;
        private static ValidationContext _validationContext;
        private static List<ValidationResult> _validationResults = new List<ValidationResult>();


        public Validation(IUserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
            _validationResults = new List<ValidationResult>();
        }

        public static bool IsValidModel<TModel>(TModel model, bool showErrors) where TModel: class, new()
        {
            _validationContext = new ValidationContext(model, null, null);
            if(!Validator.TryValidateObject(model, _validationContext, _validationResults, true)) {
                if (showErrors) { MessageBoxShowErrors(_validationResults); }
                return false;
            }
            return true;
        }

        public bool IsValidUserToCreate(UserDto user, bool showErrors)
        {
            _validationContext = new ValidationContext(user, null, null);
            if(!ValidateUser(user, _validationResults) || !Validator.TryValidateObject(user, _validationContext, _validationResults, true)) {
                if (showErrors) { MessageBoxShowErrors(_validationResults); }
                return false;
            }
            return true;
        }

        private static bool ValidateUser(UserDto user, List<ValidationResult> validationResults)
        {
            if (_userRegistrationService.UserNameExist(user.UserName)) {
                validationResults.Add(new ValidationResult("This username already exists."));
                return false;
            }
            if (_userRegistrationService.EmailExist(user.EmailAddress)) {
                validationResults.Add(new ValidationResult("This email address already registered."));
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
