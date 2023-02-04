using FluentValidation;

namespace NZWalksAPI.Validations
{
    public class LoginRequestValidator : AbstractValidator<Models.DTO.LoginRequest>
    {
        public LoginRequestValidator() 
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();


        }
    }
}
