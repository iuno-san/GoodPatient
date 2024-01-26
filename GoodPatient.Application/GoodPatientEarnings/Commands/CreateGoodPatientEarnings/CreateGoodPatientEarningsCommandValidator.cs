using FluentValidation;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Commands.CreateGoodPatientEarnings
{
    public class CreateGoodPatientEarningsCommandValidator : AbstractValidator<CreateGoodPatientEarningsCommand>
    {
        public CreateGoodPatientEarningsCommandValidator(IGoodPatientEarningsRepository repository)
        {

            RuleFor(c => c.Name)
            .NotEmpty()
            .MinimumLength(2).WithMessage("Nazwa dochodu powinna zawierać co najmniej 2 znaki")
            .MaximumLength(20).WithMessage("Nazwa dochodu powinna mieć maksymalnie 20 znaków");
        }
    }
}
