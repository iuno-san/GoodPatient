using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientService.Commands
{
    public class CreateGoodPatientServiceCommandValidator : AbstractValidator<CreateGoodPatientServiceCommand>
    {
        public CreateGoodPatientServiceCommandValidator()
        {
            RuleFor(s => s.Name).NotEmpty().NotNull();
            RuleFor(s => s.Description).NotEmpty().NotNull();
            RuleFor(s => s.GoodPatientEncodedName).NotEmpty().NotNull();
        }
    }
}
