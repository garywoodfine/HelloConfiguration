using System;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using Threenine.ConfigTest.Services;

namespace Threenine.ConfigTest.Functions
{
    public class Speak
    {
        private readonly IServiceProvider _serviceProvider;

        public Speak(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Speak() : this(StartUp.Container.BuildServiceProvider())
        {
        }

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public string Greet(ILambdaContext context)
        {
            var talk = _serviceProvider.GetService<ISpeakService>();

            return talk.Greeting;
        }
    }
}
