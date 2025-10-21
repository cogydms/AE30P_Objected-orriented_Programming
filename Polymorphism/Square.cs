namespace Module4.Classes;

public class Square : Polygon {

    public Square (double LengthPerSide)
    : base(4, LengthPerSide){ } //call the parent (base) constructor 

    public override double GetArea(){
        return LengthPerSide * LengthPerSide;
    }
}