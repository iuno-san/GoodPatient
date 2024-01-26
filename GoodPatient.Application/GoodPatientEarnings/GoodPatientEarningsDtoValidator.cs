using FluentValidation;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings
{
    public class GoodPatientEarningsDtoValidator : AbstractValidator<GoodPatientEarningsDto>
    {
        public GoodPatientEarningsDtoValidator(IGoodPatientEarningsRepository repository)
        {

        }
    }
}
