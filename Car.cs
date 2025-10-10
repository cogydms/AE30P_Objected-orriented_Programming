namespace Terminology.Classes{

    public class Car {

    public string model { get; set; }
    public int year { get; set; }
    public double StartKm { get; set; }
    public double EndKm { get; set; }
    public double fuelConsumption { get; set; }
    public double travelTime { get; set; }
    public double tripDistance { get; private set; }

        public double GetTripLength(double startKm, double endKm){
            this.StartKm = startKm;
            this.EndKm = endKm;
            tripDistance = EndKm - StartKm;
            return tripDistance;
        }

        public double GetSpeed(double travelTime){
            this.travelTime = travelTime;
            return tripDistance / travelTime;
        }

        public double GetFuelEfficiency(double fuelConsumption){
            this.fuelConsumption = fuelConsumption;
            return tripDistance / (fuelConsumption/100);
        }

        public string ClassifyCar(int year){
            this.year = DateTime.Now.Year - year;
            if (year <= 1)
                return "New car, enjoy it!";
            
            else if(year<= 3)
                return "Semi-used car, how is it going?";
            
            else if(year<= 5)
                return "Used car, it's probably a good time to start looking for a new one";
            
            else
                return "Old car, please change it!!";
        }

    }
}