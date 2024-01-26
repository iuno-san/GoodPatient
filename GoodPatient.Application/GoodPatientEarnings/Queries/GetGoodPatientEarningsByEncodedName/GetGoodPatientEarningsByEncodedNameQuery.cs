using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Queries.GetGoodPatientEarningsByEncodedName
{
    public class GetGoodPatientEarningsByEncodedNameQuery : IRequest<GoodPatientEarningsDto>
    {
        public string EncodedName { get; set; }

        public GetGoodPatientEarningsByEncodedNameQuery(string encodedName)
        {
            EncodedName = encodedName;
        }


    }
}
