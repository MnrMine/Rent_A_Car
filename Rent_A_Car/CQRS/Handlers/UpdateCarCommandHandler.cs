using Rent_A_Car.CQRS.Commands;
using Rent_A_Car.DAL;

namespace Rent_A_Car.CQRS.Handlers
{
    public class UpdateCarCommandHandler
    {
        private readonly Context _context;

        public UpdateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateCarCommand command)
        {
            var values = _context.Cars.Find(command.CarID);
            values.CarBrand = command.CarBrand;
            values.CarKM = command.CarKM;
            values.MotorPower = command.MotorPower;
            values.Price = command.Price;
            values.BodyType = command.BodyType;
            values.CarGearType = command.CarGearType;
            values.CarModel = command.CarModel;
            values.FuelType = command.FuelType;
            values.ImageUrl = command.ImageUrl;
            _context.SaveChanges();
        }
    }
}
