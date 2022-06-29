using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a collection of media items groups. Such as episodes or a show.
	/// </summary>
	public class MediaGroup
	{
		public MediaGroup()
		{
			this.Id = 0;
		}

		#region Properties

		[JsonPropertyName("season_id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("summary")]
		public string? Summary { get; set; }

		[JsonPropertyName("thumb_url")]
		public string? ImageURL { get; set; }

		[JsonPropertyName("episodes")]
		public MediaItemList? Items{ get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates the number of media items available.
		/// </summary>
		/// <returns></returns>
		public int Count()
        {
			return this.Items?.Count ?? 0;
        }

        #endregion
    }
}

