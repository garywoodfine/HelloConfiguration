using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Threenine.ConfigTest
{
    public class Handler
    {
        private ILambdaConfiguration Configuration { get; }
        public Handler()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Configuration = serviceProvider.GetService<ILambdaConfiguration>();
        }
        
        public string Hello( ILambdaContext context)
        {
            return Configuration.Configuration["hello"] ?? "None";
        }
        
        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILambdaConfiguration, LambdaConfiguration>();
        }
      
    }
}
