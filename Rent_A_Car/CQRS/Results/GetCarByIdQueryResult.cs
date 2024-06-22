﻿namespace Rent_A_Car.CQRS.Results
{
    public class GetCarByIdQueryResult
    {
        public int CarID { get; set; }
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public int CarKM { get; set; }
        public string? CarGearType { get; set; }
        public string? FuelType { get; set; }
        public string? MotorPower { get; set; }
        public string? BodyType { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
    }
}
