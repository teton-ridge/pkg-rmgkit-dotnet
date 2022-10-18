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
        public enum SlideDataType : int
        {
            unknown = 0,
            mediaitem = 1,
            usermediaitem = 2,
            show = 3,
            season = 4,
            liveevent = 5,
            livechannel = 6,
            playlist = 7,
            customitem = 8
        }
        public enum StreamStatusCode : int
        {
            notastream = 0,
            scheduled = 1,
            pre_live = 2,
            live = 3,
            completed = 4
        }
        public Slide()
        {

        }
        #region Properties
        [JsonPropertyName("slide_type")]
        public SlideType Type { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = "";

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("target")]
        public string? Target { get; set; }

        [JsonPropertyName("stream_status")]
        public StreamStatusCode StreamStatus { get; set; } = StreamStatusCode.notastream;

        [JsonPropertyName("stream_date")]
        public DateTime? StreamStart { get; set; }

        [JsonPropertyName("data")]
        public object? Data { get; set; }

        [JsonPropertyName("data_type")]
        public SlideDataType SourceType { get; set; } = SlideDataType.unknown;


        [JsonPropertyName("follow_id")]
        public long FollowID { get; set; } = 1;

        [JsonPropertyName("progress")]
        public long Progress { get; set; } = 0;

        [JsonPropertyName("duration")]
        public long Duration { get; set; } = 0;

        [JsonPropertyName("data_id")]
        public long DataID { get; set; } = 0;


        public long Sequence { get; set; } = 0;
        #endregion

    }
}
