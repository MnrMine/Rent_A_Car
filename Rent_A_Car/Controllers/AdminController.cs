using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.CQRS.Commands;
using Rent_A_Car.CQRS.Handlers;
using Rent_A_Car.CQRS.Queries;
using Rent_A_Car.MeditorPattern.Handlers;

namespace Rent_A_Car.Controllers
{
    public class AdminController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        public AdminController(GetCarQueryHandler getCarQueryHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, UpdateCarCommandHandler updateCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, CreateCarCommandHandler createCarCommandHandler)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _createCarCommandHandler = createCarCommandHandler;
        }

        public IActionResult CarList()
        {
            var values = _getCarQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(CreateCarCommand command)
        {
            _createCarCommandHandler.Handle(command);
            return RedirectToAction("CarList");
        }
        public IActionResult DeleteCar(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("CarList");
        }
        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            var value = _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCar(UpdateCarCommand command)
        {
            _updateCarCommandHandler.Handle(command);
            return RedirectToAction("CarList");
        }
    }
}
