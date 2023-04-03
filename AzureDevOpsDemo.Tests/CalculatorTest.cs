namespace AzureDevOpsDemo.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 4, 8)]
        public void CalculateSum_PositiveNumbersAsParam_ReturnSum(double a, double b, double expectedSum)
        {
            var calculator = new Calculator();

            var actualSum = calculator.CalculateSum(a, b);

            Assert.Equal(expectedSum, actualSum);
        }
    }
}