using FluentValidation;
using RSwitch.AMBS.Model.DTO.Auth;

namespace RSwitch.AMBS.Validation
{
    public class LoginRequestValidator : AbstractValidator<LoginRequestDTO>
    {
        public LoginRequestValidator()
        {
            RuleFor(m => m.Login)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .NotNull()
                //.GreaterThan(0)
                .WithMessage("Login is not valid.");
            RuleFor(m => m.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .NotNull()
                .WithMessage("Password is not valid.");
        }
    }
}