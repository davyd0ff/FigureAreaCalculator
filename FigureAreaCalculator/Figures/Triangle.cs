using FigureAreaCalculator.Interfaces;

namespace FigureAreaCalculator.Figures;

internal class Triangle : IFigure, ITriangle
{
  private readonly double _a;
  private readonly double _b;
  private readonly double _c;
  private double[] _sides;

  public Triangle(double a, double b, double c)
  {
    if (this.IsNotValidate(a, b, c))
    {
      throw new ArgumentException("sides of triangle must be greater zero");
    }

    this._a = a;
    this._b = b;
    this._c = c;

    this._sides = new[] { a, b, c };
  }

  private bool IsNotValidate(double a, double b, double c)
  {
    return a <= 0 || b <= 0 || c <= 0;
  }

  public double GetArea()
  {
    var semiPerimeter = this._sides.Sum() / 2;
    var area = Math.Sqrt(semiPerimeter);

    return area;
  }

  public bool IsRight()
  {
    var sortedSides = this._sides;
    Array.Sort(sortedSides);

    var cathetus1 = sortedSides[0];
    var cathetus2 = sortedSides[1];
    var hypotenuse = sortedSides[2];

    return hypotenuse * hypotenuse == cathetus1 * cathetus1 + cathetus2 * cathetus2;
  }
}
