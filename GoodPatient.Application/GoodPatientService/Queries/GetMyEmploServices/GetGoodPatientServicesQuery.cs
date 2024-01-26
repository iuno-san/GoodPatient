using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientService.Queries.GetGoodPatientServices
{
	public class GetGoodPatientServicesQuery : IRequest<IEnumerable<GoodPatientServiceDto>>
	{
		public string EncodedName { get; set; } = default!;
	}
}
