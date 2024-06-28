using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            List<SelectListItem> values = (from x in _context.ReceivingLocations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.LocationName,
                                               Value = x.ReceivingLocationID.ToString()
                                           }).ToList();
            ViewBag.ReceivingLocation = values;

            List<SelectListItem> values2 = (from x in _context.DestinationLocations.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.DestinationLocationName,
                                                Value = x.DestinationLocationID.ToString()
                                            }).ToList();
            ViewBag.DestinationLocation = values2;
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
