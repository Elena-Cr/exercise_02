namespace VehicleNameSpace
{

    public class Vehicle
    {
        public string Make { get; set; }
        public int Mileage { get; set; }
        public string Model { get; set; }
        public void PrintVechicleData()
        {
            Console.WriteLine("Printing car details:");
            Console.WriteLine($"Make:{Make}\nModel:{Model}\nMilage:{Mileage}");
        }

    }
}