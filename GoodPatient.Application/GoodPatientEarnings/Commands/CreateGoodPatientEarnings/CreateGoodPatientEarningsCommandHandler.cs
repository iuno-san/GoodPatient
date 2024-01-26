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

namespace GoodPatient.Application.GoodPatientEarnings.Commands.CreateGoodPatientEarnings
{
    public class CreateGoodPatientEarningsCommandHandler : IRequestHandler<CreateGoodPatientEarningsCommand>
    {
        private readonly IMapper _mapper;
        private readonly IGoodPatientEarningsRepository _GoodPatientEarningsRepository;
        private readonly IUserContext _userContext;

        public CreateGoodPatientEarningsCommandHandler(IMapper mapper, IGoodPatientEarningsRepository GoodPatientEarningsRepository, IUserContext userContext)
        {
            _mapper = mapper;
            _GoodPatientEarningsRepository = GoodPatientEarningsRepository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(CreateGoodPatientEarningsCommand request, CancellationToken cancellationToken)
        {
            var currentUser = _userContext.GetCurrentUser();

            if (currentUser == null)
            {
                return Unit.Value;
            }

            var GoodPatientEarnings = _mapper.Map<Domain.Entities.GoodPatientEarnings>(request);
            GoodPatientEarnings.EncodeName();

            GoodPatientEarnings.CreatedById = _userContext.GetCurrentUser().Id;

            await _GoodPatientEarningsRepository.CreateEarnings(GoodPatientEarnings);

            return Unit.Value;
        }
    }
}
