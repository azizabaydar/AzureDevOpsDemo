namespace AzureDevOpsDemo
{
    public class Calculator : ICalculator
    {     
        public double CalculateSum(double a, double b)
        {
            return (a + b);
        }
        public double CalculateAverage(double a, double b)
        {
            return (a >= 0 && b >= 0 ? (a + b) / 2 :
                throw new ArgumentException("All argument values ​​must be greater than or equal to 0"));
        }
    }
}
