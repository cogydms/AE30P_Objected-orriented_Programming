using System.Reflection.Metadata.Ecma335;

namespace TransportLibrary;

public class CarTransport : ITransport
{
    public double Speed { get; set; } = 60;
    public double distance { get; set; }
    public double weight { get; set; }
    double baseCost = 5;

    public double CalculateCost(double distance, double weight)
    {
        return 1.2 * distance + 0.5 * weight + baseCost;
    }
    public double CalculateDeliveryTime(double distance)
    {
        return distance / Speed;
    }
    public string ShowTransportDetails()
    {
        return $"=== CarTransport ===\nCost : {CalculateCost(distance,weight)}\nDeliveryTime:{CalculateDeliveryTime(distance):F2}";
    }
}