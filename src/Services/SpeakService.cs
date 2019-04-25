using Microsoft.Extensions.Options;
using Threenine.ConfigTest.Config;

namespace Threenine.ConfigTest.Services
{
    public class SpeakService : ISpeakService
    {
        private readonly Greeting _greeting;
        private readonly SpeakEnvironment _speakEnvironment;
      
        public SpeakService(IOptions<Greeting> hello, IOptions<SpeakEnvironment> speakEnvironment)
        {
            _greeting = hello.Value;
            _speakEnvironment = speakEnvironment.Value;

        }

        public string Greeting => string.Concat( _greeting.Message, "  ", _speakEnvironment.SaySomething);
    }
}
