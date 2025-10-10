using Terminology.Classes;
using System;

class Program {
    static void Main(){

        Car car = new Car();
        Console.WriteLine("Enter the car model: ");
        car.model = Console.ReadLine();

        Console.WriteLine("Enter the car model year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the start km: ");
        double startKm = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end km: ");
        double endKm = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fuel consumption(in liters): ");
        double fuel = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the travel time(in hours): ");
        double time = double.Parse(Console.ReadLine());

        double distance = car.GetTripLength(startKm, endKm);
        double speed = car.GetSpeed(time);
        double fueleffi = car.GetFuelEfficiency(fuel);

        Console.WriteLine("--------------------------");
        Console.WriteLine($"Car Model : {car.model}");
        Console.WriteLine($"Trip Distace: {distance:F2}");
        Console.WriteLine($"Average Speed: {speed:F2}");
        Console.WriteLine($"Fuel Efficiency: {fueleffi:F2}");
        Console.WriteLine("Car Staus: "+ car.ClassifyCar(year));


    }
}
