using cs_TDD_and_Communication;
using FluentAssertions;

namespace cs_TDD_and_Communication_Test;

    public class CaesarCipherTests()
    {
        [TestCase("northcoders", "abegupbqref", TestName = "Simple test, happy times!")]
        [TestCase("#I'm sure glad nobody can read my secret ROT13 code.", "#V'z fher tynq abobql pna ernq zl frperg EBG13 pbqr.", TestName = "Complex sentence with special characters")]
        [TestCase("", "", TestName = "Empty string")]

        [Test]
        public void TestCipher(string inputString, string expectedResult)
        {
            string result = CaesarCipher.EncodeCipher(inputString);
            result.Should().Be(expectedResult);
        }
    }
