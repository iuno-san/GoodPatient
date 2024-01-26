using GoodPatient.Application.ApplicationUser;
using AutoMapper;
using MediatR;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Commands.CreateGoodPatient
{
    public class CreateGoodPatientCommandHandler : IRequestHandler<CreateGoodPatientCommand>
    {
        private readonly IMapper _mapper;
        private readonly IGoodPatientRepository _GoodPatientRepository;
        private readonly IUserContext _userContext;

        public CreateGoodPatientCommandHandler(IMapper mapper, IGoodPatientRepository GoodPatientRepository, IUserContext userContext)
        {
            _mapper = mapper;
            _GoodPatientRepository = GoodPatientRepository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(CreateGoodPatientCommand request, CancellationToken cancellationToken)
        {
            var currentUser = _userContext.GetCurrentUser();

            if (currentUser == null)
            {
                return Unit.Value;
            }

            var GoodPatient = _mapper.Map<Domain.Entities.GoodPatient>(request);
            GoodPatient.EncodeName();

            GoodPatient.CreatedById = _userContext.GetCurrentUser().Id;

            await _GoodPatientRepository.Create(GoodPatient);

            return Unit.Value;
        }
    }
}
