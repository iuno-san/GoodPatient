using FluentValidation;

namespace GoodPatient.Application.GoodPatientEarnings.Commands.EditGoodPatientEarnings
{
    public class EditGoodPatientEarningsCommandValidator : AbstractValidator<EditGoodPatientEarningsCommand>
    {
        public EditGoodPatientEarningsCommandValidator()
        {

            RuleFor(c => c.Name)
            .NotEmpty()
            .MinimumLength(2).WithMessage("Nazwa dochodu powinna zawierać co najmniej 2 znaki")
            .MaximumLength(20).WithMessage("Nazwa dochodu powinna mieć maksymalnie 20 znaków");
        }
    }
}
