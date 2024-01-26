using AutoMapper;
using GoodPatient.Application.ApplicationUser;
using GoodPatient.Application.GoodPatientEarnings.Commands.CreateGoodPatientEarnings;
using GoodPatient.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientEarnings.Commands.DeleteGoodPatientEarnings
{
    public class DeleteGoodPatientEarningsCommandHandler : IRequestHandler<DeleteGoodPatientEarningsCommand>
    {

        private readonly IMapper _mapper;
        private readonly IGoodPatientEarningsRepository _GoodPatientEarningsRepository;
        private readonly IUserContext _userContext;

        public DeleteGoodPatientEarningsCommandHandler(IMapper mapper, IGoodPatientEarningsRepository GoodPatientEarningsRepository, IUserContext userContext)
        {
            _mapper = mapper;
            _GoodPatientEarningsRepository = GoodPatientEarningsRepository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(DeleteGoodPatientEarningsCommand request, CancellationToken cancellationToken)
        {
            var GoodPatientEarnings = await _GoodPatientEarningsRepository.GetByEncodedNameEarnings(request.EncodedName);

            var user = _userContext.GetCurrentUser();
            var isEditable = user != null || GoodPatientEarnings.CreatedById == user.Id;

            if (!isEditable)
            {
                return Unit.Value;
            }

            await _GoodPatientEarningsRepository.DeleteEarnings(GoodPatientEarnings);

            return Unit.Value;
        }
    }
}
