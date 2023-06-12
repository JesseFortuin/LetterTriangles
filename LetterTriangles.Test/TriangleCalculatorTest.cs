using LetterTriangles.BL;

namespace LetterTriangles.Test
{
    public class TriangleCalculatorTest
    {
        [Theory]
        [InlineData("codewars", "l")]
        [InlineData("triangle", "d")]
        [InlineData("youhavechosentotranslatethiskata", "a")]
        [InlineData("b", "b")]
        [InlineData("yes", "b")]
        [InlineData("hours", "y")]
        [InlineData("circlecipher", "z")]
        public void TriangleTests(string input, string expected)
        {
            //arrange
            ITriangleCalculator calculator = new TriangleCalculator();

            //act
            string actual = calculator.Triangle(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}