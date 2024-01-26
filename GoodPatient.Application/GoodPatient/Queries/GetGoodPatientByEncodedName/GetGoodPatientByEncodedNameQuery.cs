using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Queries.GetGoodPatientByEncodedName
{
    public class GetGoodPatientByEncodedNameQuery : IRequest<GoodPatientDto>
    {
        public string EncodedName { get; set; }

        public GetGoodPatientByEncodedNameQuery(string encodedName)
        {
            EncodedName = encodedName;
        }


    }
}
