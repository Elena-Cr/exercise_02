using VehicleNameSpace;

Vehicle vehicle = new();

Console.WriteLine("Please enter vehicle Make:");
vehicle.Make = Console.ReadLine();

Console.WriteLine("Please enter vehicle Mileage:");
vehicle.Mileage = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter vehicle Model:");
vehicle.Model = Console.ReadLine();

vehicle.PrintVechicleData();