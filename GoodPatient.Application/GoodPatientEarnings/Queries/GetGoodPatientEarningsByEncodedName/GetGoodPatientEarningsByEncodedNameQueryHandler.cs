using AutoMapper;
using MediatR;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Queries.GetGoodPatientEarningsByEncodedName
{
    public class GetGoodPatientEarningsByEncodedNameQueryHandler : IRequestHandler<GetGoodPatientEarningsByEncodedNameQuery, GoodPatientEarningsDto>
    {
        private readonly IGoodPatientEarningsRepository _GoodPatientEarningsRepository;
        private readonly IMapper _mapper;

        public GetGoodPatientEarningsByEncodedNameQueryHandler(IGoodPatientEarningsRepository GoodPatientEarningsRepository, IMapper mapper)
        {
            _GoodPatientEarningsRepository = GoodPatientEarningsRepository;
            _mapper = mapper;
        }

        public async Task<GoodPatientEarningsDto> Handle(GetGoodPatientEarningsByEncodedNameQuery request, CancellationToken cancellationToken)
        {
            var GoodPatientEarnings = await _GoodPatientEarningsRepository.GetByEncodedNameEarnings(request.EncodedName);

            var dtos = _mapper.Map<GoodPatientEarningsDto>(GoodPatientEarnings);

            return dtos;
        }
    }
}
