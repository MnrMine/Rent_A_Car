using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.DAL;
using Rent_A_Car.MeditorPattern.Queries;
using Rent_A_Car.Models;

namespace Rent_A_Car.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;
        private readonly Context _context;

        public DefaultController(IMediator mediator, Context context)
        {
            _mediator = mediator;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SearchCar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SearchCar(SearchCarViewModel model)
        {
            var result = await _mediator.Send(new SearchCarQuery(model.DestinationLocationID, model.ReceivingLocationID, model.DropOffDate, model.PickUpDate));
            return View(result);
        }
        public async Task<IActionResult> CarList()
        {
            var values = await _mediator.Send(new GetCarQuery());

            return View(values);
        }
    }
}
