using FluentValidation;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient
{
    public class GoodPatientDtoValidator : AbstractValidator<GoodPatientDto>
    {
        public GoodPatientDtoValidator(IGoodPatientRepository repository)
        {

            RuleFor(c => c.FullName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
                .MaximumLength(20).WithMessage("Name should have maxium of 20 characters");
        }
    }
}
