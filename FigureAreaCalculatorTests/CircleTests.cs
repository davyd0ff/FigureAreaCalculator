using FigureAreaCalculator.Figures;

namespace FigureAreaCalculatorTests;

internal class CircleTests
{
  [Test]
  public void GetArea() {
    var test_Radius = 2;
    var test_Area = Math.PI * test_Radius * test_Radius;
    var circle = new Circle(test_Radius);

    var area = circle.GetArea();

    Assert.That(area, Is.EqualTo(test_Area));
  }

  [Test]
  public void MakeCircle_WithNegativeRadius__ArgumentExceptionRised()
  {
    Assert.That(() => new Circle(-1), Throws.TypeOf<ArgumentException>());
  }

  [Test]
  public void MakeCircle_WithZeroRadius__ArgumentExceptionRised()
  {
    Assert.That(() => new Circle(0), Throws.TypeOf<ArgumentException>());
  }
}
