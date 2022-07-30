using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Content
{
    public class Slide
    {
        public enum SlideType : int
        {
            none = -1,
            link = 0,
            browser_link= 1
        }
        public Slide()
        {

        }
        #region Properties


        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("slide_type")]
        public SlideType Type { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("target")]
        public string? Target { get; set; }



        [JsonPropertyName("data")]
        public object? Data { get; set; }


        #endregion

    }
}
