using AutoMapper;
using MediatR;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Queries.GetAllGoodPatientEarnings
{
    public class GetAllGoodPatientEarningsQueryHandler : IRequestHandler<GetAllGoodPatientEarningsQuery, IEnumerable<GoodPatientEarningsDto>>
    {
        private readonly IMapper _mapper;
        private readonly IGoodPatientEarningsRepository _GoodPatientEarningsRepository;
        public GetAllGoodPatientEarningsQueryHandler( IMapper mapper, IGoodPatientEarningsRepository GoodPatientEarningsRepository)
        {
            _mapper = mapper;
            _GoodPatientEarningsRepository = GoodPatientEarningsRepository;
        }
        public async Task<IEnumerable<GoodPatientEarningsDto>> Handle(GetAllGoodPatientEarningsQuery request, CancellationToken cancellationToken)
        {
            var GoodPatientEarningss = await _GoodPatientEarningsRepository.GetAllEarnings();
            var dtos = _mapper.Map<IEnumerable<GoodPatientEarningsDto>>(GoodPatientEarningss);

            return dtos;
        }
    }
}
