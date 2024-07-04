using ReverseWords;

namespace ReverseWordTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("csharp is programming language", "language programming is csharp")]
        [InlineData("Reverse the words in this sentence", "sentence this in words the Reverse")]
        [InlineData("challenges and data structures", "structures data and challenges")]
        public void TestReverseWords(string input, string expected)
        {
            string actual = Reverse_String.ReverseWords(input);
            Assert.Equal(expected, actual);
        }
    }
}