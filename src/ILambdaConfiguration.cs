using Microsoft.Extensions.Configuration;

namespace AwsDotnetCsharp
{
    public interface  ILambdaConfiguration
    {
        IConfiguration Configuration { get; }
    }
}
