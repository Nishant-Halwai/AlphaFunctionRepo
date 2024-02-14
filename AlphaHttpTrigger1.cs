using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.AlphaFunction
{
    public class AlphaHttpTrigger1
    {
        private readonly ILogger<AlphaHttpTrigger1> _logger;

        public AlphaHttpTrigger1(ILogger<AlphaHttpTrigger1> logger)
        {
            _logger = logger;
        }

        [Function("AlphaHttpTrigger1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions! Alpha Function");
        }
    }
}
