using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Threenine.ConfigTest
{
   [JsonObject("greeting")]
    public class Greeting
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
