using WebApi.CrossCuttingConcerns.Logging;
using WebApi.CrossCuttingConcerns.Logging.Abstracts;
using WebApi.CrossCuttingConcerns.Logging.Concretes;
using WebApi.Firebase;
using WebApi.Logging;
using WebApi.ProductManager;
using ILogger = WebApi.CrossCuttingConcerns.Logging.Abstracts.ILogger;

namespace WebApi
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<LoggerOptions>().Bind
                (configuration.GetSection("RequestResponseLogger")).ValidateDataAnnotations();
            /*IOC*/
            services.AddSingleton<ILogger, Logger>();
            services.AddSingleton<ILogModelCreator, LogModelCreator>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IFirestoreProvider, FirestoreProvider>();


            return services;
        }
    }
}
