namespace FigureMath;

public class Circle : IFigure
{
    private double _radius;
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius {
        get => _radius;
        set {
            if (value >= 0) {
                _radius = value;
            }
            else {
                throw new LessThanZeroException("Radius of circle cannot be less than zero/");
            }
        }
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}