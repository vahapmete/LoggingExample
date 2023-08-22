using WebApi.CrossCuttingConcerns.Logging.Abstracts;
using WebApi.Logging;
using WebApi.Logging.Handlers;
using ILogger = WebApi.CrossCuttingConcerns.Logging.Abstracts.ILogger;

namespace WebApi.CrossCuttingConcerns.Logging.Concretes
{
    public class Logger : ILogger
    {
        private readonly ILogger<Logger> _logger;

        public Logger(ILogger<Logger> logger)
        {
            _logger = logger;
        }

        public void Log(ILogModelCreator logCreator)
        {
            //_logger.LogTrace(jsonString);
            //_logger.LogInformation(jsonString);
            //_logger.LogWarning(jsonString);
            _logger.LogCritical(logCreator.LogString());
        }

        
    }
}
    
