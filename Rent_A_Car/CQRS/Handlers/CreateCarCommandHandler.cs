﻿using Rent_A_Car.CQRS.Commands;
using Rent_A_Car.DAL;

namespace Rent_A_Car.CQRS.Handlers
{
    public class CreateCarCommandHandler
    {
        private readonly Context _context;

        public CreateCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateCarCommand command)
        {
            _context.Add(new Car
            {
                BodyType = command.BodyType,
                CarBrand = command.CarBrand,
                CarGearType = command.CarGearType,
                CarKM = command.CarKM,
                CarModel = command.CarModel,
                FuelType = command.FuelType,
                ImageUrl = command.ImageUrl,
                MotorPower = command.MotorPower,
                Price = command.Price
            });
            _context.SaveChanges();
        }
    }
}
