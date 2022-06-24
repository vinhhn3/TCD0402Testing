using NUnit.Framework;

namespace Fundamentals.UnitTests
{
  class MathTest
  {
    private Math _math;
    [SetUp]
    public void SetUp()
    {
      _math = new Math();
    }
    [TestCase(1, 1, 2)]
    [TestCase(1, -1, 0)]

    public void Add_WhenCalled_ReturnSumOfAllArguments(int a, int b, int expetedResult)
    {
      // Arrange

      // Act
      var result = _math.Add(a, b);
      // Assert
      Assert.That(result, Is.EqualTo(expetedResult));
    }
    [TestCase(1, 0, 1)]
    [TestCase(0, 1, 1)]
    [TestCase(1, 1, 1)]
    public void Max_WhenCalled_ReturnTheGreaterNumber(int a, int b, int expectedResult)
    {
      // Arrange

      // Act
      var result = _math.Max(a, b);
      // Assert
      Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
    {
      // Arrange
      var limit = 10;
      var expectedResult = new[] { 1, 3, 5, 7, 9 };
      // Act
      var result = _math.GetOddNumbers(limit);
      // Assert
      Assert.That(result, Is.EquivalentTo(expectedResult));
      Assert.That(5, Is.EqualTo(expectedResult.Length));
      Assert.That(result, Does.Contain(1));
      Assert.That(result, Does.Contain(3));
      Assert.That(result, Does.Contain(5));
      Assert.That(result, Is.Ordered);

    }

    [TestCase(1, 1, 0)]
    [TestCase(2, 1, 1)]
    [TestCase(-1, -1, 0)]
    [TestCase(2, 3, -1)]
    public void Substract_WhenCalled_ReturnSubstractionOfArguments(int a, int b, int expectedResult)
    {
      // Arrange

      // Act
      var result = _math.Substract(a, b);
      // Assert
      Assert.That(result, Is.EqualTo(expectedResult));
    }
  }
}
