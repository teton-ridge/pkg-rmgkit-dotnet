using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a specific media item.
	/// </summary>
    [DataContract]
	public class MediaItem
	{
		/// <summary>
		/// Represents a content source type.
		/// </summary>
		public enum SourceType : int {
			none = 0,
			franklyRDF = 1,
			franklyTCC = 2,
			brightcoveVOD = 3,
			brightcoveLive = 4
		}

		/// <summary>
		/// Represents a subcription level.
		/// </summary>
		public enum SubscriptionType : int {
			unknown = -1,
			none = 0,
			required = 1
		}

		public MediaItem()
		{
			this.Id = 0;
			this.Source = SourceType.none;
			this.Drm = 0;
		}

		#region Properties

		[DataMember(Name = "media_id")]
		public int Id { get; set; }

		[DataMember(Name = "external_id")]
		public string? ExternalId { get; set; }

		[DataMember(Name = "source")]
		public SourceType Source { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

		[DataMember(Name = "summary")]
		public string? Summary { get; set; }

		[DataMember(Name = "thumbnail_url")]
		public string? ImageURL { get; set; }

		[DataMember(Name = "playback_url")]
		public string? PlaybackURL { get; set; }

		[DataMember(Name = "duration_in_seconds")]
		public double? DurationInSeconds { get; set; }

		[DataMember(Name = "is_drm")]
		public int? Drm { get; set; }

		[DataMember(Name = "premium")]
		public int? Premium { get; set; }

		[DataMember(Name = "metadata")]
		public List<string>? MetaData { get; set; }

		[DataMember(Name = "tags")]
		public List<string>? Tags { get; set; }

		[DataMember(Name = "ad_tag")]
		public string? AdTag { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates if the media item is drm protected.
		/// </summary>
		/// <returns></returns>
		public bool IsDrmProtected()
        {
			return Drm == 1;
        }

		/// <summary>
		/// Indicates if the media item is a live stream.
		/// </summary>
		/// <returns></returns>
		public bool IsLive()
        {
			return this.MetaData?.Contains("livehls") ?? false;
        }

		/// <summary>
		/// Indicates if the media item has an ad tag.
		/// </summary>
		/// <returns></returns>
		public bool HasAdTag()
        {
			return !String.IsNullOrEmpty(this.AdTag);
        }

		/// <summary>
		/// Indicates if a subscription is required for playback.
		/// </summary>
		/// <returns></returns>
		public bool SubscriptionIsRequired()
        {
			return this.Premium == 1;
        }

		/// <summary>
		/// Returns a formatted runtime label.
		/// </summary>
		/// <returns></returns>
		public string? RuntimeLabel()
        {
			if (this.DurationInSeconds != null)
            {
				TimeSpan dur = TimeSpan.FromSeconds(this.DurationInSeconds.Value);
				return dur.ToString("hh:mm:ss");
            }
			return null;
        }

        #endregion
    }
}

