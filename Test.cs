using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1
{
    public class Test:ITest
    {
        private readonly ILogger<Test> _logger;
        public Test(ILogger<Test> logger)
        {
            _logger = logger;
        }

        public void welcome(string message)
        {
            _logger.LogInformation("Welcome message : " + message);
        }

    }
}
