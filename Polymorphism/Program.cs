using Module4.Classes;

/*
Square S1 = new Square(5.5);
Console.WriteLine($"Square's Perimeter: {S1.GetPerimeter()}");
Console.WriteLine($"Square's Area: {S1.GetArea():F2}");
Console.WriteLine("--------");

MyHexagon H1 = new MyHexagon(5.5, 3.0);
Console.WriteLine($"Hexagon's Perimeter: {H1.GetPerimeter()}");
Console.WriteLine($"Hexagon's Area: {H1.GetArea():F2}");
*/

Console.WriteLine("Enter the length of one side of the square: ");
double squareLength = double.Parse(Console.ReadLine());
Square S1 = new Square(squareLength);
Console.WriteLine($"Square's Perimeter: {S1.GetPerimeter()}");
Console.WriteLine($"Square's Area: {S1.GetArea():F2}");

Console.WriteLine("--------");

Console.WriteLine("Enter the length of one side of the hexagon: ");
double hexLength = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the apothem of the hexagon: ");
double hexApothem = double.Parse(Console.ReadLine());
MyHexagon H1 = new MyHexagon(hexLength, hexApothem);
Console.WriteLine($"Hexagon's Perimeter: {H1.GetPerimeter()}");
Console.WriteLine($"Hexagon's Area: {H1.GetArea():F2}");
