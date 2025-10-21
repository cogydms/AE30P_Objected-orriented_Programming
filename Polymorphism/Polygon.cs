namespace Module4.Classes;

public abstract class Polygon{

    public int NumOfSides {get; set;}
    public double LengthPerSide {get; set;}

    protected Polygon(int NumOfSides, double LengthPerSide){ //Constructor
        this.NumOfSides = NumOfSides;
        this.LengthPerSide = LengthPerSide;
    }

    public virtual double GetPerimeter (){
        return NumOfSides * LengthPerSide ;
    }
    
    public abstract double GetArea();
}