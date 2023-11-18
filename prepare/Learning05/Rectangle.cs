public class Rectangle : Shape
{
    private double _widht;
    private double _lenght;

    public Rectangle(string color, double widht, double lenght) : base (color)
    {
        _widht = widht;
        _lenght = lenght;
    }

    public override double GetArea()
    {
        return _widht * _lenght;
    }
}