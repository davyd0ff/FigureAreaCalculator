using FigureAreaCalculator.Interfaces;

namespace FigureAreaCalculator.Figures;

public class Triangle : IFigure
{
  private double[] _sides;

  public Triangle(double a, double b, double c)
  {
    this._sides = new[] { a, b, c };
    Array.Sort(this._sides);

    if (this.SidesNotGraterZero())
    {
      throw new ArgumentException("sides of triangle must be greater zero");
    }
    if (this.TriangleCanNotBeExist())
    {
      throw new ArgumentException("triangle cannot be exists, because third side greater sum of other");
    }
  }

  private bool SidesNotGraterZero()
  {
    return this._sides[0] <= 0;
  }
  private bool TriangleCanNotBeExist()
  {
    return this._sides[0] + this._sides[1] <= this._sides[2];
  }

  public double GetArea()
  {
    var semiPerimeter = this._sides.Sum() / 2;
    var area = Math.Sqrt(semiPerimeter);

    return area;
  }

  public bool IsRight()
  {
    var cathetus1 = this._sides[0];
    var cathetus2 = this._sides[1];
    var hypotenuse = this._sides[2];

    return hypotenuse * hypotenuse == cathetus1 * cathetus1 + cathetus2 * cathetus2;
  }
}
