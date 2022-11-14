using FigureMath;

namespace FigureMathNUnitTests;

public class CircleTests
{
    [Test]
    public void GetArea_WithRightCircleRadius() {
        var circle = new Circle(10);
        
        var circleArea = circle.GetArea();
        
        Assert.That(circleArea, Is.EqualTo(314.159265358979).Within(1e-12));
    }
    
    [Test]
    public void CreateByCtor_WithNegativeCircleRadius() {
        Assert.Throws<LessThanZeroException>(() => new Circle(-10));
    }
    
    [Test]
    public void GetArea_WithZeroCircleRadius()
    {
        var circle = new Circle(0);
        
        var circleArea = circle.GetArea();
        
        Assert.That(circleArea, Is.EqualTo(0d).Within(1e-12));
    }
}