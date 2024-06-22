﻿namespace Rent_A_Car.CQRS.Commands
{
    public class RemoveCarCommand
    {
        public int CarId { get; set; }

        public RemoveCarCommand(int carId)
        {
            CarId = carId;
        }
    }
}
