using System.Runtime.CompilerServices;
using WebApi.Firebase;
using WebApi.Logging;
using WebApi.Logging.Handlers;
using WebApi.ProductManager;

namespace WebApi
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<RequestResponseLoggerOption>().Bind
                (configuration.GetSection("RequestResponseLogger")).ValidateDataAnnotations();
            /*IOC*/
            services.AddSingleton<IRequestResponseLogger, RequestResponseLogger>();
            services.AddScoped<IRequestResponseLogModelCreator, RequestResponseLogModelCreator>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IFirestoreProvider, FirestoreProvider>();

            return services;
        }
    }
}
