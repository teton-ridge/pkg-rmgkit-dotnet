using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a grouping of shows or media items.
	/// </summary>
	public class MediaRequest
	{
		public MediaRequest()
		{
		}

		#region Properties

		[JsonPropertyName("media_id")]
		public long MediaId { get; set; } = 0;

		[JsonPropertyName("site")]
		public string? Site { get; set; } = "";

		[JsonPropertyName("platform_id")]
		public string? PlatformID { get; set; } = "";

		[JsonPropertyName("media_type")]
		public int MediaType { get; set; } = 0;

		[JsonPropertyName("jwid")]
		public string? JWID { get; set; } = "";

		[JsonPropertyName("user_id")]
		public string? UserID { get; set; } = "";

		#endregion

	}
}

