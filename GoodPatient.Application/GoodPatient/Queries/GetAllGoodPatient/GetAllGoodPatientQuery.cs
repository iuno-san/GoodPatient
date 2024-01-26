using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Queries.GetAllGoodPatient
{
    public class GetAllGoodPatientQuery : IRequest<IEnumerable<GoodPatientDto>>
    {
    }
}
