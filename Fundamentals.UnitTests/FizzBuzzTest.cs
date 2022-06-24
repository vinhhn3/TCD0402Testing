using NUnit.Framework;

namespace Fundamentals.UnitTests
{
  public class FizzBuzzTest
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetOutput_InputDiviableBy3And5_ReturnFizzBuzz()
    {
      // Arrange
      var input = 15;
      var expectedOutput = "FizzBuzz";
      // Act
      var output = FizzBuzz.GetOutput(input);
      // Assert
      Assert.That(output, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void GetOutPut_InputDiviableOnlyBy3_ReturnFizz()
    {
      // Arrange
      var input = 9;
      var expectedOutput = "Fizz";
      // Act
      var output = FizzBuzz.GetOutput(input);
      // Assert
      Assert.That(output, Is.EqualTo(expectedOutput));
    }
    [Test]
    public void GetOutPut_InputDiviableOnlyBy5_ReturnBuzz()
    {
      // Arrange
      var input = 25;
      var expectedOutput = "Buzz";
      // Act
      var output = FizzBuzz.GetOutput(input);
      // Assert
      Assert.That(output, Is.EqualTo(expectedOutput));
    }

    [TestCase(11, "11")]
    [TestCase(22, "22")]
    [TestCase(29, "29")]
    [TestCase(-4, "-4")]

    public void GetOutPut_InputNotDiviableBy3And5_ReturnInput(int input, string expectedResult)
    {
      // Arrange

      // Act
      var output = FizzBuzz.GetOutput(input);
      // Assert
      Assert.That(output, Is.EqualTo(expectedResult));
    }
    [TestCase(3, "Fizz")]
    [TestCase(5, "Buzz")]
    [TestCase(15, "FizzBuzz")]
    [TestCase(4, "4")]
    [TestCase(0, "FizzBuzz")]
    [TestCase(-3, "Fizz")]
    [TestCase(-5, "Buzz")]
    [TestCase(-15, "FizzBuzz")]
    [TestCase(-4, "-4")]
    public void GetOutput_AllCases(int input, string expectedOutput)
    {
      // Arrange

      // Act
      var output = FizzBuzz.GetOutput(input);
      // Assert
      Assert.That(output, Is.EqualTo(expectedOutput));
    }
  }
}