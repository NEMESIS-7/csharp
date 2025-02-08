using System;

namespace _201_Assignment.Inheritance_VehicleRentalMGTSystem
{
    public class Vehicle
    {
        private string VehicleId;
        private string Brand;
        private string Model;
        private bool IsAvailable;

        public Vehicle(
            string VehicleId,
            string Brand,
            string Model,
            bool IsAvailable
        )
        {
            this.VehicleId = VehicleId;
            this.Brand = Brand;
            this.Model = Model;
            this.IsAvailable = true;
        }

        public void RentVehicle()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Vehicle has been rented successfully");
            }
            else
            {
                throw new Exception("Vehicle is not available for rent");
            }
        }

        public void ReturnVehicle()
        {
            IsAvailable = true;
            Console.WriteLine("Vehicle is returned");
        }
    }
}