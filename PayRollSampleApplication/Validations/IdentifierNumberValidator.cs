using FluentValidation;

namespace PayRollSampleApplication.Validations
{
    public class IdentifierNumberValidator : AbstractValidator<string>
    {
        public IdentifierNumberValidator()
        {
            RuleFor(c => c)
                .NotEmpty().WithMessage("identifier number required")
                .Matches(@"^[0-9]{10}$").WithMessage("identifier number invalid");
        }
    }
}
