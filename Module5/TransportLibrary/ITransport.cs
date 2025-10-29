namespace TransportLibrary;

public interface ITransport
{
    double Speed { get; set; }
    public double CalculateCost(double distance, double weight);
    public double CalculateDeliveryTime(double distance);
    public string ShowTransportDetails();
    
}
