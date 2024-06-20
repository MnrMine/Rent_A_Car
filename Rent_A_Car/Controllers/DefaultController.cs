using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.MeditorPattern.Queries;

namespace Rent_A_Car.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchCar()
        {
            return View();
        }
        public async Task<IActionResult> CarList()
        {
            var values = await _mediator.Send(new GetCarQuery());

            return View(values);
        }
    }
}
