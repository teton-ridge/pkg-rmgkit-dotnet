using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a specific 'show' or collection of media item groups.
	/// </summary>
	public class Show
	{
		public Show()
		{
			this.Id = 0;
			this.Groups = new MediaGroupList();
		}

		#region Properties

		[JsonPropertyName("show_id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("summary")]
		public string? Summary { get; set; }

		[JsonPropertyName("thumb_url")]
		public string? ImageURL { get; set; }

		[JsonPropertyName("seasons")]
		public MediaGroupList Groups { get; set; }

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

