using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
    public class UserMediaItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";
        [JsonPropertyName("progress")]
        public long Progress { get; set; } = 0;
        [JsonPropertyName("slide")]
        public RMGKit.Models.Content.Slide Slide { get; set; }
    }
}
