using Microsoft.Extensions.Configuration;

namespace Threenine.ConfigTest
{
    public interface  ILambdaConfiguration
    {
        IConfigurationRoot Configuration { get; }
    }
}
