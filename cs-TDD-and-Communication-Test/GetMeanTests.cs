
using cs_TDD_and_Communication;
using FluentAssertions;

namespace cs_TDD_and_Communication_Test
{
    internal class GetMeanTests
    {


        [Test]

        public void TestGetMean_double_Numbers_1_to_10()
        {
            // Arrange
            double[] testInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double expectedOutput = 5.5f;

            //Act

            double testReturn = ReturnMean.CalculateMean(testInput);

            //Assert
            testReturn.Should().Be(expectedOutput);
        }



        [Test]
        public void TestGetMean_int()
        {
            int[] testInput = { 3, 4, 5 };
            double expectedOutput = 4.0;

            double testReturn =ReturnMean.CalculateMean(testInput);

            testReturn.Should().Be(expectedOutput);
        }



        //empty case
        [Test]

        public void TestGetMean_empty_argument()
        {
            int[] testInput1 = { };
            double[] testInput2 = { };
            bool expectedOutput1 =false;
            bool expectedOutput2 =false;

            try
            {
                double testReturn1 = ReturnMean.CalculateMean(testInput1);
            }
            catch (ArgumentException)
            {
                expectedOutput1 = true;
            }

            try
            {
                double testReturn2 = ReturnMean.CalculateMean(testInput2);
            }
            catch (ArgumentException)
            {
                expectedOutput2 = true;
            }

            Assert.Multiple(() =>
            {
                Assert.That(expectedOutput1);
                Assert.That(expectedOutput2);
            });

               
        }

        //one element
        // negative numbers don't break CalculateMean
    }
}
