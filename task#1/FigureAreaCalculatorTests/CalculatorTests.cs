using FigureAreaCalculator;
using FigureAreaCalculator.Interfaces;
using Moq;

namespace FigureAreaCalculatorTests;

internal class CalculatorTests
{
  [Test]
  public void Calculate()
  {
    var mockedFigure = new Mock<IFigure>();

    CalculatorArea.Calculate(mockedFigure.Object);

    mockedFigure.Verify(m => m.GetArea(), Times.Once);
  }
}
