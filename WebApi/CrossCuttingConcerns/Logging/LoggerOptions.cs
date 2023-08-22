namespace WebApi.CrossCuttingConcerns.Logging;

public class LoggerOptions
{
    public bool IsEnabled { get; set; }
    public string Name { get; set; }
    public string DateTimeFormat { get; set; }
}