using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a grouping of shows or media items.
	/// </summary>
	public class MediaCategory
	{
		public MediaCategory()
		{
		}

		#region Properties

		[JsonPropertyName("container_id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

        [JsonPropertyName("shows")]
        public ShowList? Shows { get; set; }

        [JsonPropertyName("episodes")]
        public MediaItemList? MediaItems { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Indicates the number of shows available.
        /// </summary>
        /// <returns></returns>
        public int ShowCount()
        {
            return this.Shows?.Count ?? 0;
        }

        ///// <summary>
        ///// Indicates the number of media items available.
        ///// </summary>
        ///// <returns></returns>
        public int MediaItemCount()
        {
            return this.MediaItems?.Count ?? 0;
        }

        ///// <summary>
        ///// Indicates if any media items are available.
        ///// </summary>
        ///// <returns></returns>
        public bool HasMediaItems()
        {
            return this.MediaItems != null;
        }

        #endregion
    }
}

