
using FluentValidation;
using PayRollSampleApplication.Entities.DTOS;

namespace PayRollSampleApplication.Validations;
public class EmployeeValidator : AbstractValidator<AddOrUpdateEmployeeDto>
{
    public EmployeeValidator()
    {
        RuleFor(x => x.FullName)
          .NotEmpty().WithMessage("name is required")
          .MaximumLength(50);

        RuleFor(x => x.IdentifierNumber)
          .SetValidator(new IdentifierNumberValidator());

        RuleForEach(x => x.Dependents)
                 .Cascade(CascadeMode.Continue)
                 .ChildRules(dep =>
                 {
                     if (dep != null)
                     {
                         dep.RuleFor(x => x.IdentifierNumber)
                         .SetValidator(new IdentifierNumberValidator());
                     }
                 });

        RuleFor(x => x.HomeAddress).MaximumLength(100);

        RuleFor(x => x.DepartmentId)
            .NotEmpty().WithMessage("Department Id is required");

        RuleFor(x => x.JobPositionId)
            .NotEmpty().WithMessage(" Job Position Id is required");

        RuleFor(x => x.BirthDate)
                      .NotEmpty().WithMessage("birth date required")
                      .Must(x => DateTime.Now.Date >= x.Date.AddYears(21) &&
                       DateTime.Now.Date < x.Date.AddYears(50))
                      .WithMessage("birth date invalid, must between 21 to 50 years");

    }
}
