using FigureAreaCalculator.Interfaces;

namespace FigureAreaCalculator.Figures;

public class Circle : IFigure
{
  private readonly double _radius;

  public Circle(double radius)
  {
    if (this.IsNotValidate(radius))
    {
      throw new ArgumentException("radius must be greater zero");
    }

    this._radius = radius;
  }

  private bool IsNotValidate(double radius)
  {
    return radius <= 0;
  }

  public double GetArea()
  {
    return Math.PI * this._radius * this._radius;
  }
}
