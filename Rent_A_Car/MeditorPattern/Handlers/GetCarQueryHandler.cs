using MediatR;
using Microsoft.EntityFrameworkCore;
using Rent_A_Car.DAL;
using Rent_A_Car.MeditorPattern.Queries;
using Rent_A_Car.MeditorPattern.Results;

namespace Rent_A_Car.MeditorPattern.Handlers
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, List<GetCarQueryResult>>
    {
        private readonly Context _context;
        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<List<GetCarQueryResult>> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars.Select(x => new GetCarQueryResult
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

            }).ToListAsync();
        }
    }
}
