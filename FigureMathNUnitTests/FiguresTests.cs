using FigureMath;

namespace FigureMathNUnitTests;

public class FiguresTests
{
    [Test]
    public void GetArea_ForFiguresCollection() {
        var figures = new List<IFigure>();
        var expectedAreas = new List<double>();
        
        figures.Add(new Triangle(1,2,2));
        expectedAreas.Add(0.9682458365518543);
        figures.Add(new Circle(3));
        expectedAreas.Add(28.274333882308138);
        
        var actualAreas = figures.Select(f => f.GetArea());
        
        Assert.That(actualAreas, Is.EqualTo(expectedAreas).AsCollection.Within(1e-12));
    }
}