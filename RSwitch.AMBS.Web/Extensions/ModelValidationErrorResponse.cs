using Microsoft.AspNetCore.Mvc.ModelBinding;
using RSwitch.AMBS.Model.DTO;

namespace RSwitch.AMBS.Web.Extensions
{
    internal static class ModelValidationErrorResponse
    {
        internal static ErrorResponseDTO PrepareValidationError(ModelStateDictionary modelState)
        {
            var errors = new ErrorResponseDTO();
            var message = string.Empty;

            foreach (var error in modelState)
            {
                message += $"{error.Value.Errors.Select(x => x.ErrorMessage).FirstOrDefault()} \\n";
            }

            errors.Error = message;

            return errors;
        }
    }
}
