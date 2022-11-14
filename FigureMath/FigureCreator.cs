namespace FigureMath;

public abstract class FigureCreator
{
    public abstract IFigure FactoryMethod();
}

public class CircleCreator : FigureCreator
{
    public override IFigure FactoryMethod()
    {
        return new Circle();
    }
}