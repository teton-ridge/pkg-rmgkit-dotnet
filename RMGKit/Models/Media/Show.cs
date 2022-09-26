using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a specific 'show' or collection of media item groups.
	/// </summary>
	public class Show
	{
		public enum ShowDisplayType : int
		{
			displayPoster = 0,
			displayBanner = 1,
			displayAnimated = 2,
			displayVideo=3
		}

		public Show()
		{
			this.Id = 0;
			this.Groups = new MediaGroupList();
			this.DisplayType = ShowDisplayType.displayPoster;
			this.DisplayData = String.Empty;
		}

		#region Properties

		[JsonPropertyName("show_id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("summary")]
		public string? Summary { get; set; }

		[JsonPropertyName("display_type")]
		public ShowDisplayType DisplayType { get; set; }

		[JsonPropertyName("display_data")]
		public string? DisplayData { get; set; }

		[JsonPropertyName("thumbnail_url")]
		public string? ImageURL { get; set; }

		[JsonPropertyName("seasons")]
		public MediaGroupList Groups { get; set; }

		[JsonPropertyName("follow_list_id")]
		public int FollowListID { get; set; } = 0;

		#endregion

		#region Methods

		/// <summary>
		/// Indicates the number of media item groups available.
		/// </summary>
		/// <returns></returns>
		public int GroupCount()
        {
			return this.Groups?.Count ?? 0;
        }

        #endregion
    }
}

