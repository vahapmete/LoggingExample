using Newtonsoft.Json;
using WebApi.CrossCuttingConcerns.Logging.Abstracts;

namespace WebApi.CrossCuttingConcerns.Logging.Concretes;

public class LogModelCreator : ILogModelCreator
{
    public LogModel LogModel { get; private set; }

    public LogModelCreator()
    {
        LogModel = new LogModel();
    }

    public string LogString()
    {
        var jsonString = JsonConvert.SerializeObject(LogModel);
        return jsonString;
    }
}