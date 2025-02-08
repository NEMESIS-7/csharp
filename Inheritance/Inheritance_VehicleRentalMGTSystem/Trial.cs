using System;

namespace _201_Assignment.Inheritance_VehicleRentalMGTSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Car car = new Car(
                "220111222",
                "Ford",
                "Mustang Dark Horse",
                true,
                5
            );
            try
            {
                car.RentVehicle();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                car.ReturnVehicle();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(car.CalculateRentalCost(5));
        }
    }
}