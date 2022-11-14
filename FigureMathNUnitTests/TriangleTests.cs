using FigureMath;

namespace FigureMathNUnitTests;

public class TriangleTests
{
    
    [Test]
    public void GetArea_WithRightTriangleSides()
    {
        var triangle = new Triangle(1,1,1);
        
        var triangleArea = triangle.GetArea();
        
        Assert.That(triangleArea, Is.EqualTo(0.4330127018922193).Within(1e-12));
    }
    
    
    [Test]
    public void CreateByCtor_WithNegativeSide() {
        Assert.Throws<LessThanZeroException>(() => new Triangle(-10, 1,1));
    }
    
    
    [Test]
    public void IsRectangular_WithRightTriangleSides_ReturnsFalse()
    {
        var triangle = new Triangle(1,1,1);
        
        Assert.That(triangle.IsRectangular(), Is.False);
    }
    
    [Test]
    public void IsRectangular_WithRightTriangleSides_ReturnsTrue()
    {
        var triangle = new Triangle(1,1,1);
        
        Assert.That(triangle.IsRectangular(), Is.False);
    }
    
}