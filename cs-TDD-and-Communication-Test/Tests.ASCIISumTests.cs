using FluentAssertions;
using cs_TDD_and_Communication;
namespace cs_TDD_and_Communication_Test;

public partial class Tests
{
    public class ASCIISumTests
    {
        //Happy times
        [Test]
        [TestCase("", 0)]

        [TestCase("\0", 0)]
        [TestCase("A", 65 )]
        [TestCase("a", 97)]
        [TestCase("@", 64)]
        [TestCase("7", 55)]
        [TestCase("northcoders", 1195)]
        [TestCase("Northcoders", 1163)]
  
        public void TestCalculateASCIISum_HappyTimes(string inputString, int expectedResult)
        {
            int result = ASCIISumify.Sum(inputString);
            Assert.That(expectedResult == result);

        }
        [Test]

        [TestCase(null, true)]
        [TestCase("hello", false)]
        public void TestCalculateASCIISum_NullString(string? inputString, bool expectedResult)
        {
            bool isError = false;

            try
            {
                int result = ASCIISumify.Sum(inputString);
                
            }
            catch(ArgumentNullException)
            {
                isError = true;
            }

            Assert.That(isError == expectedResult);
            
        }
    }
}