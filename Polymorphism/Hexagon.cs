namespace Module4.Classes;

public class Hexagon : Polygon {

    public double Apothem {get; set;}

    protected Hexagon(double LengthPerSide, double Apothem )
    :base(6, LengthPerSide){
        this.Apothem = Apothem;
    }

    public override double GetArea(){
        return GetPerimeter() * Apothem / 2;
    }
}

public class MyHexagon : Hexagon {
    public MyHexagon (double LengthPerSide, double Apothem)
    : base (LengthPerSide, Apothem){ }
}