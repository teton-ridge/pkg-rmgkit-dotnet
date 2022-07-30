﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Content
{
	/// <summary>
	/// Represents a content page
	/// </summary>
	public class Page
	{
		public Page()
		{

		}

		#region Properties
		[JsonPropertyName("title")]
		public string? Title { get; set; }

        [JsonPropertyName("blocks")]
        public List<Block>? Blocks { get; set; }

        [JsonPropertyName("navigation")]
        public RMGKit.Models.Navigation.Navigation? Navigation { get; set; }
        #endregion

        #region Methods

        ///// <summary>
        ///// Indicates if any media items are available.
        ///// </summary>
        ///// <returns></returns>
        public int BlockCount()
        {
            if (this.Blocks != null)
                return Blocks.Count;
            else
                return 0;
        }

        public int NavCount()
        {
            if (this.Navigation != null)
                return Navigation.Count;
            else
                return 0;
        }
        #endregion
    }
}

