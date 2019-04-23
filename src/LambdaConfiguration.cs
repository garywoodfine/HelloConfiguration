using Microsoft.Extensions.Configuration;

namespace AwsDotnetCsharp
{
    public class LambdaConfiguration : ILambdaConfiguration
    {
        public IConfiguration Configuration { get; }
    }
}
