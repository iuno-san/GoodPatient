using AutoMapper;
using MediatR;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Queries.GetAllGoodPatient
{
    public class GetAllGoodPatientQueryHandler : IRequestHandler<GetAllGoodPatientQuery, IEnumerable<GoodPatientDto>>
    {
        private readonly IMapper _mapper;
        private readonly IGoodPatientRepository _GoodPatientRepository;
        public GetAllGoodPatientQueryHandler( IMapper mapper, IGoodPatientRepository GoodPatientRepository)
        {
            _mapper = mapper;
            _GoodPatientRepository = GoodPatientRepository;
        }
        public async Task<IEnumerable<GoodPatientDto>> Handle(GetAllGoodPatientQuery request, CancellationToken cancellationToken)
        {
            var GoodPatients = await _GoodPatientRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<GoodPatientDto>>(GoodPatients);

            return dtos;
        }
    }
}
