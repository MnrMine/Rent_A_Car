﻿using Rent_A_Car.CQRS.Queries;
using Rent_A_Car.CQRS.Results;
using Rent_A_Car.DAL;

namespace Rent_A_Car.CQRS.Handlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly Context _context;

        public GetCarByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetCarByIdQueryResult Handle(GetCarByIdQuery query)
        {
            var value = _context.Cars.Find(query.Id);
            return new GetCarByIdQueryResult
            {
                CarID = value.CarID,
                CarBrand = value.CarBrand,
                CarModel = value.CarModel,
                BodyType = value.BodyType,
                CarGearType = value.CarGearType,
                CarKM = value.CarKM,
                FuelType = value.FuelType,
                ImageUrl = value.ImageUrl,
                MotorPower = value.MotorPower,
                Price = value.Price

            };
        }
    }
}
