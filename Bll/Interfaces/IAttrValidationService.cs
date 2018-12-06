using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bll.Interfaces
{
    public interface IAttrValidationService
    {
        bool IsValidModel<TModel>(TModel model, List<ValidationResult> validationResults);
    }
}
