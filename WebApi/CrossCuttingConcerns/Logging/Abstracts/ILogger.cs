namespace WebApi.CrossCuttingConcerns.Logging.Abstracts;

public interface ILogger
{
    void Log(ILogModelCreator logCreator);
}