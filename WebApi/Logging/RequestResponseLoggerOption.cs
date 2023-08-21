namespace WebApi.Logging;

public class RequestResponseLoggerOption
{
    public bool IsEnabled { get; set; }
    public string Name { get; set; }
    public string DateTimeFormat { get; set; }
}