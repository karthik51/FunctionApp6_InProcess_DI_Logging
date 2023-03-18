using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private ITest _test;

        public Function1(ITest test,ILogger<Function1> logger)
        {

            _logger = logger;
            _test = test;

        }

        [FunctionName("Function1")]
        public void Run([BlobTrigger("document/{name}", Connection = "connectionname")]Stream myBlob, string name)//, ILogger _logger)
        {
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");

            _test.welcome("Karthikeyan");
        }
    }
}
