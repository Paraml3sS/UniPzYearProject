using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Bll.Interfaces;

namespace Bll.Services
{
    public class AttrValidationService : IAttrValidationService
    {
        private static ValidationContext _validationContext;
        private static List<ValidationResult> _validationResults;


        public AttrValidationService()
        {
        }

        public bool IsValidModel<TModel>(TModel model, List<ValidationResult> validationResults)
        {
            _validationContext = new ValidationContext(model, null, null);
            if(!Validator.TryValidateObject(model, _validationContext, validationResults, true)) {
                return false;
            }
            return true;
        }
    }
}
