using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevOpsDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculator _calculator;
        public CalculateController(ICalculator calculator) 
        {
            _calculator = calculator;
        }
        [HttpGet, Route("Sum", Name = "Sum")]
        public double Sum(double a, double b)
        {
            return _calculator.CalculateSum(a, b);
        }

        [HttpGet, Route("Average", Name = "Average")]
        public double Average(double a, double b)
        {
            return _calculator.CalculateAverage(a, b);
        }

    }
}
