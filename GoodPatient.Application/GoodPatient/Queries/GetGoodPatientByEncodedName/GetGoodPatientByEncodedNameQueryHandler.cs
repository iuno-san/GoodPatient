using AutoMapper;
using MediatR;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Queries.GetGoodPatientByEncodedName
{
    public class GetGoodPatientByEncodedNameQueryHandler : IRequestHandler<GetGoodPatientByEncodedNameQuery, GoodPatientDto>
    {
        private readonly IGoodPatientRepository _GoodPatientRepository;
        private readonly IMapper _mapper;

        public GetGoodPatientByEncodedNameQueryHandler(IGoodPatientRepository GoodPatientRepository, IMapper mapper)
        {
            _GoodPatientRepository = GoodPatientRepository;
            _mapper = mapper;
        }

        public async Task<GoodPatientDto> Handle(GetGoodPatientByEncodedNameQuery request, CancellationToken cancellationToken)
        {
            var GoodPatient = await _GoodPatientRepository.GetByEncodedName(request.EncodedName);

            var dtos = _mapper.Map<GoodPatientDto>(GoodPatient);

            return dtos;
        }
    }
}
