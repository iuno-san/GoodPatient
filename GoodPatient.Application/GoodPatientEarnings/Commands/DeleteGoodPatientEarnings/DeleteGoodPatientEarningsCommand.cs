using GoodPatient.Application.GoodPatientEarnings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Commands.DeleteGoodPatientEarnings
{
    public class DeleteGoodPatientEarningsCommand : GoodPatientEarningsDto, IRequest
    {
    }
}
