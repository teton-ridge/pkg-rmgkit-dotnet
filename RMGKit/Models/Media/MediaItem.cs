using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a specific media item.
	/// </summary>
	public class MediaItem
	{
		/// <summary>
		/// Represents a content source type.
		/// </summary>
		public enum SourceType : int {
			none = 0,
			RFDNews = 1,
			TCCNews = 2,
			OTTVOD = 3,
			OTTLive = 4
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
			this.EpisodicTag=String.Empty;
		}

		#region Properties

		[JsonPropertyName("media_id")]
		public int Id { get; set; }

		[JsonPropertyName("external_id")]
		public string? ExternalId { get; set; }

		[JsonPropertyName("source")]
		public SourceType Source { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }


		[JsonPropertyName("display_title")]
		public string? DisplayTitle { get; set; }

		[JsonPropertyName("episodic_tag")]
		public string EpisodicTag { get; set; }

		[JsonPropertyName("release_date")]
		public DateTime ReleaseDate { get; set; }

		[JsonPropertyName("policy_key")]
		public string? PolicyKey { get; set; }

		[JsonPropertyName("summary")]
		public string? Summary { get; set; }

		[JsonPropertyName("thumbnail_url")]
		public string? ImageURL { get; set; }

		[JsonPropertyName("playback_url")]
		public string? PlaybackURL { get; set; }

		[JsonPropertyName("duration_in_seconds")]
		public double? DurationInSeconds { get; set; }

		[JsonPropertyName("is_drm")]
		public int? Drm { get; set; }

		[JsonPropertyName("premium")]
		public int? Premium { get; set; }

		[JsonPropertyName("metadata")]
		public List<string>? MetaData { get; set; }

		[JsonPropertyName("tags")]
		public List<string>? Tags { get; set; }

		[JsonPropertyName("ad_tag")]
		public string? AdTag { get; set; }

		[JsonPropertyName("follow_list_id")]
		public int FollowListID { get; set; } = 0;

		[JsonPropertyName("progress")]
		public int Progress { get; set; } = 0;

		public string Episode
		{
			get {
				string ep = string.Empty;
				//Episode 
				if (EpisodicTag.Length > 5)
                {
					ep = EpisodicTag.Substring(6);
					if (ep.Length > 0)
					{
						if (ep.All(char.IsNumber))
                        {
							ep = "Episode " + long.Parse(ep).ToString();
                        }
                        else
                        {
							ep = "Episode " + ep;
						}
					}
				}	
				// release Date
				if (ReleaseDate != null)
                {
					ep = ep + "   \u2022   Air Date:" + ReleaseDate.ToString("MMM dd, yyyy");
				}
				return ep; 
			}
		}

		public int StartTime { get; set; } = 0;

		[JsonPropertyName("is_following")]
		public int IsFollowing { get; set; }

		#endregion

		#region Methods
		/// <summary>
		/// Indicates if the media item is drm protected.
		/// </summary>
		/// <returns></returns>


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
				return this.Premium == 1 && this.Tags.Count > 0;
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
            }
			return null;
        }
		public string? TitleLabel()
		{
			if (this.DisplayTitle != null)
			{
				if (this.DisplayTitle.Length > 0)
                {
					return this.DisplayTitle;
                }				
			}
			return this.Title;
		}
		public string? SeoDuration()
		{
			if (this.DurationInSeconds != null)
			{
				TimeSpan dur = TimeSpan.FromSeconds(this.DurationInSeconds.Value);
				return "PT"+dur.ToString("hh\\Hmm\\Mss\\S");
			}
			return null;
		}
		#endregion
	}
}

