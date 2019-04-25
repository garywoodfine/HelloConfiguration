using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Threenine.ConfigTest.Config;
using Threenine.ConfigTest.Services;

namespace Threenine.ConfigTest
{
    public class StartUp
    {
         public static IServiceCollection Container => ConfigureServices(LambdaConfiguration.Configuration); 
                
        
                private static IServiceCollection ConfigureServices(IConfigurationRoot root)
                {
                    var services = new ServiceCollection();
                    services.Configure<Greeting>(options =>
                        root.GetSection("greeting").Bind(options));
                    
                    services.AddTransient<ISpeakService, SpeakService>();
                    services.Configure<SpeakEnvironment>(options => root.GetSection("SpeakEnvironment").Bind(options));
                   return services;
        
                }
    }
}
