using GoodPatient.Domain.Interfaces;
using MediatR;
using GoodPatient.Application.ApplicationUser;


namespace GoodPatient.Application.GoodPatientEarnings.Commands.EditGoodPatientEarnings
{
    internal class EditGoodPatientEarningsCommandHandler : IRequestHandler<EditGoodPatientEarningsCommand>
    {
        private readonly IGoodPatientEarningsRepository _repository;
        private readonly IUserContext _userContext;

        public EditGoodPatientEarningsCommandHandler(IGoodPatientEarningsRepository repository, IUserContext userContext)
        {
            _repository = repository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(EditGoodPatientEarningsCommand request, CancellationToken cancellationToken)
        {
            var GoodPatientEarnings = await _repository.GetByEncodedNameEarnings(request.EncodedName!);

            var user = _userContext.GetCurrentUser();
            var isEditable = user != null || GoodPatientEarnings.CreatedById == user.Id;

            if (!isEditable)
            {
                return Unit.Value;
            }

            GoodPatientEarnings.Name = request.Name;
            GoodPatientEarnings.Amount = request.Amount;
            GoodPatientEarnings.PatientName = request.PatientName;
            GoodPatientEarnings.DateOfVisit = request.DateOfVisit;
            GoodPatientEarnings.VisitDescription = request.VisitDescription;
            GoodPatientEarnings.AdditionalNotes = request.AdditionalNotes;
            GoodPatientEarnings.PaymentMethod = request.PaymentMethod;

            await _repository.Commit();

            return Unit.Value;
        }
    }
}
