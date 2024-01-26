using AutoMapper;
using MediatR;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientService.Queries.GetGoodPatientServices
{
	public class GetGoodPatientServicesQueryHandler : IRequestHandler<GetGoodPatientServicesQuery, IEnumerable<GoodPatientServiceDto>>
	{
		private readonly IMapper _mapper;
		private readonly IGoodPatientServiceRepository _GoodPatientService;

		public GetGoodPatientServicesQueryHandler(IMapper mapper, IGoodPatientServiceRepository GoodPatientService)
        {
			_mapper = mapper;
			_GoodPatientService = GoodPatientService;
		}

        public async Task<IEnumerable<GoodPatientServiceDto>> Handle(GetGoodPatientServicesQuery request, CancellationToken cancellationToken)
		{
			var result = await _GoodPatientService.GetAllByEncodedName(request.EncodedName);

			var dtos = _mapper.Map<IEnumerable<GoodPatientServiceDto>>(result);

			return dtos;
		}
	}
}
