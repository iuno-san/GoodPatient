using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Queries.GetAllGoodPatientEarnings
{
    public class GetAllGoodPatientEarningsQuery : IRequest<IEnumerable<GoodPatientEarningsDto>>
    {
    }
}
