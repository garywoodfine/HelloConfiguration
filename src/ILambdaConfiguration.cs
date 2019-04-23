using Microsoft.Extensions.Configuration;

namespace Threenine.ConfigTest
{
    public interface  ILambdaConfiguration
    {
        IConfiguration Configuration { get; }
    }
}
