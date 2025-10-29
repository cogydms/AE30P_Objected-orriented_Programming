using TransportLibrary;

Console.WriteLine("Select transport: 1) CarTransport 2)ShipTransport 3)AirTransport");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the distance(km):");
double distance = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the weight(kg):");
double weight = double.Parse(Console.ReadLine());

switch (number)
{
    case 1:
        CarTransport C1 = new CarTransport();
        C1.distance = distance;
        C1.weight = weight;
        Console.WriteLine(C1.ShowTransportDetails());
        break;
    case 2:
        ShipTransport S1 = new ShipTransport();
        S1.distance = distance;
        S1.weight = weight;
        Console.WriteLine(S1.ShowTransportDetails());

        break;
    case 3:
        AirTransport A1 = new AirTransport();
        A1.distance = distance;
        A1.weight = weight;
        Console.WriteLine(A1.ShowTransportDetails());
        break;
    default:
        Console.WriteLine("Invalid choice...");
        break;
}