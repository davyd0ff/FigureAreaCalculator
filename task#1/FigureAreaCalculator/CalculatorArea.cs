using FigureAreaCalculator.Interfaces;

namespace FigureAreaCalculator;

public static class CalculatorArea
{
  public static double Calculate<T>(T figure) where T : IFigure
  {
    return figure.GetArea();
  }
}
