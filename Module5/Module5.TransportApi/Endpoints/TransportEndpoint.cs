using TransportLibrary;
using Module5.TransportApi.Models;

namespace Module5.TransportApi.Endpoints;

public static class TransportApi{

    static string endpoint = "/api/transport";

    public static void MapTransportEndpoints(this WebApplication app){
        app.MapPost(endpoint,(TransportRequest request) =>
        {
            ITransport transport = null;
            string name = null;
            double speed = 0;
            switch (request.Method){
                case "Car":
                    transport = new CarTransport();
                    name = "Car";
                    speed = transport.Speed;
                break;

                case "Ship":
                    transport = new ShipTransport();
                    name = "Ship";
                    speed = transport.Speed;
                break;

                case "Air":
                    transport = new AirTransport();
                    name= "Air";
                    speed = transport.Speed;
                break;
            }

            if(transport is not null){
                var cost = transport.CalculateCost(request.Distance, request.Weight);
                var delivery = transport.CalculateDeliveryTime(request.Distance);

                TransportResponse response = new TransportResponse(){
                    DeliveryTime = delivery,
                    Cost = cost,
                    Speed = speed,
                    TransportName = name

                };
                return Results.Ok(response);
            }
            else {
                return Results.BadRequest(new {Error = "Transport method not recognized"});
            }
        });
    }
}