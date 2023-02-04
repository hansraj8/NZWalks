using FluentValidation;

namespace NZWalksAPI.Validations
{ 
    //using fluent validation
    public class AddRegionRequestValidations : AbstractValidator<Models.DTO.AddRegionRequest>
    {
        public AddRegionRequestValidations()
        {
            RuleFor(x => x.Code).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Area).GreaterThan(0);
            RuleFor(x => x.Population).GreaterThanOrEqualTo(0);



        }
    }
}
