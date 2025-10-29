using System.Reflection.Metadata.Ecma335;

namespace TransportLibrary;

public class AirTransport : ITransport
{
    public double Speed { get; set; } = 500;
    public double distance { get; set; }
    public double weight { get; set; }
    double baseCost = 10;
    public double loadTime = 1;
    public double unloadTime = 0.5;

    public double CalculateCost(double distance, double weight)
    {
        return 5 * distance + 2 * weight + baseCost;
    }
    public double CalculateDeliveryTime(double distance)
    {
        return loadTime + distance / Speed + unloadTime;
    }
    public string ShowTransportDetails()
    {
        return $"=== AirTransport ===\nCost : {CalculateCost(distance,weight)}\nDeliveryTime:{CalculateDeliveryTime(distance):F2}";
    }
}