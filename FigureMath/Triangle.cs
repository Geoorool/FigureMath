namespace FigureMath;

public class Triangle : IFigure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    private readonly double _tolerance = 1e-12;
    
    public double SideA {
        get => _sideA;
        set => SetSide(value, ref _sideA);
    }

    public double SideB {
        get => _sideB;
        set => SetSide(value, ref _sideB);
    }

    public double SideC {
        get => _sideC;
        set => SetSide(value, ref _sideC);
    }

    public Triangle(double sideA, double sideB, double sideC) {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public Triangle(double sideA, double sideB, double sideC, double tolerance) {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        _tolerance = tolerance;
    }

    private static void SetSide(double value, ref double side) {
        if (value >= 0) {
            side = value;
        }
        else {
            throw new LessThanZeroException("Side of triangle cannot be less than zero.");
        }
    }

    public bool IsRectangular() {
        var sortedSides = new[] { SideA, SideB, SideC }.OrderBy(s => s).ToArray();
        return Math.Abs(sortedSides[0] * sortedSides[0] + sortedSides[1] * sortedSides[1] -
                        sortedSides[2] * sortedSides[2]) < _tolerance;
    }

    public double GetArea() {
        var semiPer = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPer * (semiPer - SideA) * (semiPer - SideB) * (semiPer - SideC));
    }
}