namespace WebApi.Logging.Handlers;

public interface IRequestResponseLogModelCreator
{
    RequestResponseLogModel LogModel { get; }
    string LogString();
}