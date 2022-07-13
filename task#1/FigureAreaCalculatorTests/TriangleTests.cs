using FigureAreaCalculator.Figures;

namespace FigureAreaCalculatorTests;

internal class TriangleTests
{
  [Test]
  public void GetArea()
  {
    var triangle = new Triangle(1, 3, 4);

    var area = triangle.GetArea();

    Assert.That(area, Is.EqualTo(2));
  }

  [Test]
  public void Triangle_IsRight()
  {
    var triangle = new Triangle(5, 3, 4);

    var triangleIsRight = triangle.IsRight();

    Assert.IsTrue(triangleIsRight);
  }

  [Test]
  public void Triangle_IsNotRight()
  {
    var triangle = new Triangle(1, 2, 3);

    var triangleIsRight = triangle.IsRight();

    Assert.IsFalse(triangleIsRight);
  }

  [Test]
  public void MakeTriangle_WithANegativeSide__ArgumentExceptionRised()
  {
    Assert.That(() => new Triangle(1, -1, 2), Throws.TypeOf<ArgumentException>());
  }

  [Test]
  public void MakeTriangle_WithAZeroSide__ArgumentExceptionRised()
  {
    Assert.That(() => new Triangle(1, 0, 5), Throws.TypeOf<ArgumentException>());
  }
}
