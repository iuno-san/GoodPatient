using GoodPatient.Application.GoodPatient;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Commands.DeleteGoodPatient
{
    public class DeleteGoodPatientCommand : GoodPatientDto, IRequest
    {
    }
}
