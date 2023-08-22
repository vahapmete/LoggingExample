namespace WebApi.CrossCuttingConcerns.Logging.Abstracts;

public interface ILogModelCreator
{
    LogModel LogModel { get; }
    string LogString();
}