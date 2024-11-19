using cs_TDD_and_Communication;
using FluentAssertions;

namespace cs_TDD_and_Communication_Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NumberManipulator_Test1SumMiddleNumbers()
    {
        //Arrange
        int[] numbers1 = {1, 2, 3, 4, 5};
        int expectedResult1 = 9;


        //Act
        int result = NumberManipulator.SumMiddleNumbers(numbers1);

        //Assert
        result.Should().Be(expectedResult1);

    }

    [Test]
    public void NumberManipulator_Test1SumMiddleNumbers_LessThan3Elements()
    {
        int[] numbers = { 2, 3 };
        int expectedResult = 0;

        int[] numbers1 = { 2 };
        int expectedResult1 = 0;

        int[] numbers2 = { };
        int expectedResult2 = 0;

        int result = NumberManipulator.SumMiddleNumbers(numbers);
        int result1 = NumberManipulator.SumMiddleNumbers(numbers1);
        int result2 = NumberManipulator.SumMiddleNumbers(numbers2);

        Assert.Multiple(() =>
        {
            Assert.That(expectedResult == result);
            Assert.That(expectedResult1 == result1);
            Assert.That(expectedResult2 == result2);
        });


    }

    [Test]
    public void NumberManipulator_Test1SumMiddleNumbers_AllNumbersEqual()
    {
        //Arrange
        int[] numbers = { 1, 1, 1, 1, 1 };
        int expectedResult = 3;

        //Act
        int result = NumberManipulator.SumMiddleNumbers(numbers);

        //Assert
        result.Should().Be(expectedResult);
    }

    [TestCase(new int[] { 1, 1, 2000000001, 1000000000, 2000000000 }, true)]
    [TestCase(new int[] { 1, 1, 1,1,1, }, false)]

    [Test]
    public void NumberManipulator_Test1SumMiddleNumbers_VeryLargeNumber(int[] numbers, bool expectedResult)
    {
        //Arrange
        bool isError = false;

        //Act
        try
        {
            int result = NumberManipulator.SumMiddleNumbers(numbers);
        }
        catch (ArgumentException)
        {
            isError = true;
        }

        //Assert

        isError.Should().Be(expectedResult);
    }
}