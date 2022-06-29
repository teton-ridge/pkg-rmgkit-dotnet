using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.News
{
	/// <summary>
	/// Represents an individual news article.
	/// </summary>
	public class Article
	{
		/// <summary>
		/// Represents a feature flag applied to an article.
		/// </summary>
		public enum FlagType : int
		{
			none = 0,
			breaking = 1,
			live = 2,
			pinned = 3
		}

		/// <summary>
		/// Represents an article source type.
		/// </summary>
		public enum SourceType : int
		{
			none = 0,
			rfd = 1,
			tcc = 2,
			prca = 3,
			ad = 99
		}

		public Article()
		{
			this.Id = 0;
			this.Flag = FlagType.none;
			this.Source = SourceType.none;
		}

		#region Properties

		[JsonPropertyName("story_id")]
		public int Id { get; set; }

		[JsonPropertyName("breaking")]
		public FlagType Flag { get; set; }

		[JsonPropertyName("source")]
		public SourceType Source { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("summary")]
		public string? Summary { get; set; }

		[JsonPropertyName("thumb_url")]
		public string? ImageURL { get; set; }

        #endregion

    }
}

