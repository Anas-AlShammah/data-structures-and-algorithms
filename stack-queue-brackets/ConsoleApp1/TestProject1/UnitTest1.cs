using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("()[[Extra Characters]]", true)] 
        [InlineData("a[b]c)", false)] 
        public void TestAreCharactersBalanced(string input, bool expected)
        {
            var bracket = new Brackets();
            // Act
            bool actualResult = bracket.ValidateBrackets(input);

            // Assert
            Assert.Equal(expected, actualResult);
        }
    }
}