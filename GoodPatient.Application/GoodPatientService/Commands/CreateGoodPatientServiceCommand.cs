using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientService.Commands
{
    public class CreateGoodPatientServiceCommand : GoodPatientServiceDto, IRequest
    {
        public string GoodPatientEncodedName { get; set; } = default!;
    }
}
