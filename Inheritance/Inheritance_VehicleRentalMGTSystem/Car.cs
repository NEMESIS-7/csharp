namespace _201_Assignment.Inheritance_VehicleRentalMGTSystem
{
    public class Car : Vehicle
    {
        public int SeatingCapacity{ get; private set; }

        public Car(string VehicleId, string Brand, string Model, bool IsAvailable, int SeatingCapacity) : base(
            VehicleId, Brand, Model, IsAvailable)
        {
            this.SeatingCapacity = SeatingCapacity;
        }

        public string CalculateRentalCost(int days)
        {
            double cost = 1000 * days + SeatingCapacity * 50;
            return "Rental cost for " + days + " days: $" + cost;
        }
    }
}