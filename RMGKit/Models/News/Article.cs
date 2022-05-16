using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.News
{
	/// <summary>
	/// Represents an individual news article.
	/// </summary>
	[DataContract]
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

		[DataMember(Name = "story_id")]
		public int Id { get; set; }

		[DataMember(Name = "breaking")]
		public FlagType Flag { get; set; }

		[DataMember(Name = "source")]
		public SourceType Source { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

		[DataMember(Name = "summary")]
		public string? Summary { get; set; }

		[DataMember(Name = "thumb_url")]
		public string? ImageURL { get; set; }

        #endregion

    }
}

