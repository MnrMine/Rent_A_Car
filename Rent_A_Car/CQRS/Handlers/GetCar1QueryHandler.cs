using Rent_A_Car.CQRS.Results;
using Rent_A_Car.DAL;

namespace Rent_A_Car.CQRS.Handlers
{
    public class GetCar1QueryHandler
    {
        private readonly Context _context;

        public GetCar1QueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCar1QueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetCar1QueryResult
            {
                CarID = x.CarID,
                CarBrand = x.CarBrand,
                CarModel = x.CarModel,
                CarKM = x.CarKM,
                FuelType = x.FuelType,
                MotorPower = x.MotorPower,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                BodyType = x.BodyType,
                CarGearType = x.CarGearType

            }).ToList();
            return values;
        }
    }
}
