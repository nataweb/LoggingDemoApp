using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        //The standart way of capturing the category
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("DemoCategory");
        }

        public void OnGet()
        {
            //logging levels
            _logger.LogTrace("this a trace log");
            _logger.LogDebug("this ia a debug log");
            _logger.LogInformation("this is an information log");
            _logger.LogWarning("this is a warning log");
            _logger.LogError("this is an error log");
            _logger.LogCritical("this is a critical log");

            //_logger.LogError("The server went down temporarily at {Time}",DateTime.UtcNow);

            //try
            //{
            //    throw new Exception("You forgot to catch me!");
            //}
            //catch (Exception ex)
            //{

            //    _logger.LogCritical(ex, "There was a bad exception at {Time}", DateTime.UtcNow);
            //}
        }
    }
        public class LoggingId
        {
          public const int DemoCode = 1001;
        }
}

