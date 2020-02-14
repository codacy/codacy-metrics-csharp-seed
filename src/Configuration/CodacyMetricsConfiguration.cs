using Newtonsoft.Json;

namespace Codacy.Metrics.Seed.Configuration
{
    public class CodacyMetricsConfiguration
    {
        [JsonProperty(PropertyName = "files")] public string[] Files { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
