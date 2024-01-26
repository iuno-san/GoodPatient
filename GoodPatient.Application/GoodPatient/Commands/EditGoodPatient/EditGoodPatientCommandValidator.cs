using FluentValidation;

namespace GoodPatient.Application.GoodPatient.Commands.EditGoodPatient
{
    public class EditGoodPatientCommandValidator : AbstractValidator<EditGoodPatientCommand>
    {
        public EditGoodPatientCommandValidator()
        {
            RuleFor(c => c.FullName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Nazwa pacjenta powinna zawierać co najmniej 2 znaki")
                .MaximumLength(20).WithMessage("Nazwa pacjenta powinna mieć maksymalnie 20 znaków");

        }
    }
}
