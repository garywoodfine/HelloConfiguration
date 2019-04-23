using Microsoft.Extensions.Options;

namespace Threenine.ConfigTest.Services
{
    public class SpeakService : ISpeakService
    {
        private readonly Greeting _greeting;
        public SpeakService(IOptions<Greeting> hello)
        {
            _greeting = hello.Value;
        }

        public string Greeting => _greeting.Message;
    }
}
