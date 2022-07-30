using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Content
{
    public class Block
    {
        public enum BlockType : int
        {
            none = -1,
            text_content = 0,
            html_content = 1,
            carousel_banner = 2,
            carousel_hero = 3,
            carousel_large_thumb = 4,
            carousel_thumb_single = 5,
            carousel_thumb_double = 6,
            grid_thumbnails = 7,
            grid_thumbnails_x3 = 8,
            grid_thumbnails_x4 = 9,
            grid_thumbnails_x5 = 10,
            grid_thumbnails_paged = 11,
            banner_small = 12,
            banner_large = 13
        }
        public Block()
        {

        }
        #region Properties
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("block_type")]
        public BlockType Type { get; set; }

        [JsonPropertyName("html")]
        public string? HTML { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("max_height")]
        public string? MaxHeight { get; set; }

        [JsonPropertyName("min_height")]
        public string? MinHeight { get; set; }

        [JsonPropertyName("slides")]
        public List<RMGKit.Models.Content.Slide>? Slides { get; set; }


        #endregion

        #region Methods

        ///// <summary>
        ///// Indicates if any media items are available.
        ///// </summary>
        ///// <returns></returns>
        public int SlideCount()
        {
            if (this.Slides != null)
                return Slides.Count;
            else
                return 0;
        }

        public bool HasHTML()
        {
            return !string.IsNullOrWhiteSpace(HTML);
        }
        #endregion
    }
}
