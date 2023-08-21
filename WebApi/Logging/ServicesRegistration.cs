using System.Runtime.CompilerServices;
using WebApi.Logging.Handlers;

namespace WebApi.Logging
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddOptions<RequestResponseLoggerOption>().Bind
                (configuration.GetSection("RequestResponseLogger")).ValidateDataAnnotations();
            /*IOC*/
            services.AddSingleton<IRequestResponseLogger, RequestResponseLogger>();
            services.AddScoped<IRequestResponseLogModelCreator, RequestResponseLogModelCreator>();

            return services;
        }
    }
}
