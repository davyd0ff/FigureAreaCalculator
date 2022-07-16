using FigureAreaCalculator.Figures;

namespace FigureAreaCalculatorTests;

internal class TriangleTests
{
  [Test]
  public void GetArea()
  {
    var triangle = new Triangle(1.0, 2.0, 2.0);
    var testArea = Math.Sqrt((1.0 + 2.0 + 2.0) / 2);

    var area = triangle.GetArea();

    Assert.That(area, Is.EqualTo(testArea));
  }

  [Test]
  public void Triangle_IsRight()
  {
    var triangle = new Triangle(5.0, 3.0, 4.0);

    var triangleIsRight = triangle.IsRight();

    Assert.IsTrue(triangleIsRight);
  }

  [Test]
  public void Triangle_IsNotRight()
  {
    var triangle = new Triangle(1.0, 2.0, 2.0);

    var triangleIsRight = triangle.IsRight();

    Assert.IsFalse(triangleIsRight);
  }

  [Test]
  public void MakeTriangle_WithANegativeSide__ArgumentExceptionRised()
  {
    Assert.That(() => new Triangle(1.0, -1.0, 2.0), Throws.TypeOf<ArgumentException>());
    Assert.That(() => new Triangle(-1.0, 1.0, 2.0), Throws.TypeOf<ArgumentException>());
    Assert.That(() => new Triangle(1.0, 1.0, -2.0), Throws.TypeOf<ArgumentException>());
  }

  [Test]
  public void MakeTriangle_WithAZeroSide__ArgumentExceptionRised()
  {
    Assert.That(() => new Triangle(1.0, 0.0, 5.0), Throws.TypeOf<ArgumentException>());
    Assert.That(() => new Triangle(0.0, 1.0, 5.0), Throws.TypeOf<ArgumentException>());
    Assert.That(() => new Triangle(1.0, 5.0, 0.0), Throws.TypeOf<ArgumentException>());
  }
  [Test]
  public void MakeTriangle_WithThirdSideGreaterThanSumOfOthers()
  {
    Assert.That(() => new Triangle(1.0, 1.0, 1000.0), Throws.TypeOf<ArgumentException>());
    Assert.That(() => new Triangle(1.0, 1000.0, 1.0), Throws.TypeOf<ArgumentException>());
    Assert.That(() => new Triangle(1000.0, 1.0, 1.0), Throws.TypeOf<ArgumentException>());
  }
}
