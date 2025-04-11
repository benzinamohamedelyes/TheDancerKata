namespace TheDancerKataTests
{
    public class DancerTest
    {
        [Theory]
        [InlineData(3, -4)]
        [InlineData(1000000, -5)]
        [InlineData(0, 0)]
        public void GetPositionAtWithCorrectInputShouldReturnCorrectAnswer(int input, int expectedResult)
        {
            // Arrange
            var dancer = new TheDancerKata.Domain.Dancer();
            // Act
            int actualResult = dancer.GetPositionAt(input);
            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}