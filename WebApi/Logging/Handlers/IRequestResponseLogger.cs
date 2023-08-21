namespace WebApi.Logging.Handlers;

public interface IRequestResponseLogger
{
    void Log(IRequestResponseLogModelCreator logCreator);
}