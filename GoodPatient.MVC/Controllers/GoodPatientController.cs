using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoodPatient.Application.GoodPatient;
using GoodPatient.Application.GoodPatient.Commands.CreateGoodPatient;
using GoodPatient.Application.GoodPatient.Commands.EditGoodPatient;
using GoodPatient.Application.GoodPatient.Queries.GetAllGoodPatient;
using GoodPatient.Application.GoodPatient.Queries.GetGoodPatientByEncodedName;
using GoodPatient.Application.GoodPatientService.Commands;
using GoodPatient.Application.GoodPatientService.Queries.GetGoodPatientServices;
using GoodPatient.MVC.Extensions;
using GoodPatient.Application.GoodPatient.Commands.DeleteGoodPatient;
using GoodPatient.Application.GoodPatientEarnings.Queries.GetAllGoodPatientEarnings;
using GoodPatient.Application.GoodPatientEarnings.Queries.GetGoodPatientEarningsByEncodedName;
using GoodPatient.Application.GoodPatientEarnings.Commands.EditGoodPatientEarnings;
using GoodPatient.Application.GoodPatientEarnings.Commands.DeleteGoodPatientEarnings;
using GoodPatient.Application.GoodPatientEarnings.Commands.CreateGoodPatientEarnings;

namespace GoodPatient.MVC.Controllers
{
    public class GoodPatientController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GoodPatientController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var GoodPatients = await _mediator.Send(new GetAllGoodPatientQuery());

            var filteredGoodPatients = GoodPatients.Where(e => e.IsEditable);

            return View(filteredGoodPatients);
        }

        [Authorize]
		public IActionResult Calendar()
		{
			return View();
		}

		[Authorize]
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }

        [Route("GoodPatient/{encodedName}/Details")]
        public async  Task<IActionResult> Details(string encodedName)
        {
            var dto = await _mediator.Send(new GetGoodPatientByEncodedNameQuery(encodedName));

            return View(dto);
        }

        [Route("GoodPatient/{encodedName}/Edit")]
        public async Task<IActionResult> Edit(string encodedName)
        {
            var dto = await _mediator.Send(new GetGoodPatientByEncodedNameQuery(encodedName));

            EditGoodPatientCommand model = _mapper.Map<EditGoodPatientCommand>(dto);

            if (!dto.IsEditable)
            {
                return RedirectToAction("NoAccess", "Home");
            }

            return View(model);
        }

        [HttpPost]
        [Route("GoodPatient/{encodedName}/Edit")]
        public async Task<IActionResult> Edit(string encodedName, EditGoodPatientCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            this.SetNotification("success", $"Twoje nowe dane zostały zapisane dla: {command.FullName}");
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Delete(string encodedName, bool confirmed = false)
        {
            var dto = await _mediator.Send(new GetGoodPatientByEncodedNameQuery(encodedName));

            if (!dto.IsEditable)
            {
                return RedirectToAction("NoAccess", "Home");
            }

            if (confirmed)
            {
                await _mediator.Send(new DeleteGoodPatientCommand { EncodedName = encodedName });
                this.SetNotification("success", $"Pacjent został usunięty.");
                return RedirectToAction(nameof(Index));
            }

            return View(dto);
        }

        [HttpPost]
        [Authorize]
        [Route("GoodPatient/{encodedName}/Delete")]
        public async Task<IActionResult> DeleteConfirmed(string encodedName)
        {
            return RedirectToAction(nameof(Delete), new { encodedName, confirmed = true });
        }


        [Authorize]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [Authorize]

        public async Task<IActionResult> Create(CreateGoodPatientCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            this.SetNotification("success", $"Dodano nowego pacjenta: {command.FullName}");
            return RedirectToAction(nameof(Index));
        }





        //GoodPatientEarnings
        /*---------------------------------------------------------------------------*/

        [Authorize]
        public async Task<IActionResult> Earnings()
        {
            var GoodPatientEarnings = await _mediator.Send(new GetAllGoodPatientEarningsQuery());

            var filteredGoodPatientEarnings = GoodPatientEarnings.Where(e => e.IsEditable);

            return View(filteredGoodPatientEarnings);
        }

        [Route("GoodPatient/{encodedName}/DetailsEarnings")]
        public async Task<IActionResult> DetailsEarnings(string encodedName)
        {
            var dto = await _mediator.Send(new GetGoodPatientEarningsByEncodedNameQuery(encodedName));

            return View(dto);
        }

        [Route("GoodPatient/{encodedName}/EditEarnings")]
        public async Task<IActionResult> EditEarnings(string encodedName)
        {
            var dto = await _mediator.Send(new GetGoodPatientEarningsByEncodedNameQuery(encodedName));

            EditGoodPatientEarningsCommand model = _mapper.Map<EditGoodPatientEarningsCommand>(dto);

            if (!dto.IsEditable)
            {
                return RedirectToAction("NoAccess", "Home");
            }

            return View(model);
        }

        [HttpPost]
        [Route("GoodPatient/{encodedName}/EditEarnings")]
        public async Task<IActionResult> EditEarnings(string encodedName, EditGoodPatientEarningsCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            this.SetNotification("success", $"Dane twojego zarobku zostały zapisane dla: {command.Name}");
            return RedirectToAction(nameof(Earnings));
        }

        [Authorize]
        public async Task<IActionResult> DeleteEarnings(string encodedName, bool confirmed = false)
        {
            var dto = await _mediator.Send(new GetGoodPatientEarningsByEncodedNameQuery(encodedName));

            if (!dto.IsEditable)
            {
                return RedirectToAction("NoAccess", "Home");
            }

            if (confirmed)
            {
                await _mediator.Send(new DeleteGoodPatientEarningsCommand { EncodedName = encodedName });
                this.SetNotification("success", $"Dochód został usunięty.");
                return RedirectToAction(nameof(Earnings));
            }

            return View(dto);
        }

        [HttpPost]
        [Authorize]
        [Route("GoodPatient/{encodedName}/DeleteEarnings")]
        public async Task<IActionResult> DeleteConfirmedEarnings(string encodedName)
        {
            return RedirectToAction(nameof(DeleteEarnings), new { encodedName, confirmed = true });
        }


        [Authorize]
        public IActionResult CreateEarnings()
        {

            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateEarnings(CreateGoodPatientEarningsCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            this.SetNotification("success", $"Dodano nowy zarobek: {command.Name}");
            return RedirectToAction(nameof(Earnings));
        }


        /* [HttpGet]
         [Route("GoodPatient/{encodedName}/GoodPatientService")]
         public async Task<IActionResult> GetGoodPatientService(string encodedName)
         {
             var data = await _mediator.Send(new GetGoodPatientServicesQuery() { EncodedName = encodedName });
             return Ok(data);
         }*/
    }
}
