using FluentValidation;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Commands.CreateGoodPatient
{
    public class CreateGoodPatientCommandValidator : AbstractValidator<CreateGoodPatientCommand>
    {
        public CreateGoodPatientCommandValidator(IGoodPatientRepository repository)
        {
            RuleFor(c => c.FullName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Nazwa pacjenta powinna zawierać co najmniej 2 znaki")
                .MaximumLength(20).WithMessage("Nazwa pacjenta powinna mieć maksymalnie 20 znaków");

        }
    }
}
