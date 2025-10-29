using System.Reflection.Metadata.Ecma335;

namespace TransportLibrary;

public class ShipTransport : ITransport
{
    public double Speed { get; set; } = 30;
    public double distance { get; set; }
    public double weight { get; set; }
    double baseCost = 3;
    public double loadTime = 2;
    public double unloadTime = 1;

    public double CalculateCost(double distance, double weight)
    {
        return 0.5 * distance + 0.2 * weight + baseCost;
    }
    public double CalculateDeliveryTime(double distance)
    {
        return loadTime + distance / Speed + unloadTime;
    }
    public string ShowTransportDetails()
    {
        return $"=== ShipTransport ===\nCost : {CalculateCost(distance,weight)}\nDeliveryTime:{CalculateDeliveryTime(distance):F2}";
    }
}