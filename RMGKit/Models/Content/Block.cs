﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Content
{
    public class Block
    {
        public enum BlockType : int
        {
            Unknown = 0,
            html_content = 1,
            carousel_banner = 2,
            carousel_hero = 3,
            carousel_thumb_single_large = 4,
            carousel_thumb_single_medium = 5,
            carousel_thumb_single_small = 6,
            carousel_thumb_double_small = 7,
            grid_thumbnails_Large = 8,
            grid_thumbnails_Medium = 9,
            grid_thumbnails_Small= 10,
            grid_thumbnails_paged = 11,
            banner_small = 12,
            banner_large = 13,
            Preformatted_Content = 14
        }
        public enum BlockDataType : int
        {
            Unknown =0 ,
            Shows_ByContainer = 1,
            Live_AllContent = 2,
            Episodes_BySeason = 3,
            Shows_ByTag = 4,
            Episodes_ByTag = 5,
            Custom_PLayList = 6,
            Live_Channels = 7,
            Live_Published = 8,
            Live_Unpublished = 9,
            Live_Scheduled = 10,
            Live_Published_Unpublished = 11,
            Live_Events = 12,
            Live_ByTag = 13,
            EPG_Feed = 14,
            Search_Results = 15,
            Rodeo_Schedule = 16,
            User_History = 17,
            User_Favorites = 18,
            Account_Top_Navigation = 19,
            Shows_ByDynamicTag = 20,
            Episodes_ByDynamicTag = 21,
            Live_ByDynamicTag = 22,
            Live_ExceptChannel = 23
        }
        public Block()
        {

        }
        #region Properties
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("block_type")]
        public BlockType Type { get; set; }

        [JsonPropertyName("block_name")]
        public string BlockName { get; set; } = "";

        [JsonPropertyName("block_data_type")]
        public BlockDataType DataType { get; set; }


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

        [JsonPropertyName("use_personalization")]
        public int UsePersonalization { get; set; }

        [JsonPropertyName("show_when")]
        public string ShowWhen { get; set; } = "";

        [JsonPropertyName("hide_when")]
        public string HideWhen { get; set; } = "";
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
