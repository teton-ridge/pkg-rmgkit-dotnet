using System;
using System.Text.Json.Serialization;
using RMGKit.Models.Event;
using RMGKit.Models.News;
using RMGKit.Models.Media;

namespace RMGKit.Models.Rodeo
{
	/// <summary>
	/// Represents a rodeo event.
	/// </summary>
	public class Rodeo
	{
		public Rodeo()
		{
			this.Id = 0;
			this.Name = "";
		}

		#region Properties

		[JsonPropertyName("rodeo_id")]
		public int Id { get; set; }

		[JsonPropertyName("rodeo_name")]
		public string Name { get; set; }

		[JsonPropertyName("start_date")]
		public string? StartDateTS { get; set; }

		[JsonPropertyName("end_date")]
		public string? EndDateTS { get; set; }

		[JsonPropertyName("season")]
		public int? Season { get; set; }

		[JsonPropertyName("venue")]
		public Venue? Venue { get; set; }

		[JsonPropertyName("logo_url")]
		public string? LogoUrl { get; set; }

		[JsonPropertyName("tickets_url")]
		public string? TicketsUrl { get; set; }

		[JsonPropertyName("description")]
		public string? DescriptionHtml { get; set; }

		[JsonPropertyName("results_html")]
		public string? ResultsHtml { get; set; }

		[JsonPropertyName("live_id")]
		public string? LiveStreamId { get; set; }

		[JsonPropertyName("related_stories")]
		public ArticleList? RelatedStories { get; set; }

		[JsonPropertyName("media")]
		public MediaItemList? RelatedMedia { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Returns the event date range label.
		/// </summary>
		/// <returns></returns>
		public string? EventDateLabel()
        {
			if (!String.IsNullOrEmpty(this.StartDateTS) && !String.IsNullOrEmpty(this.EndDateTS))
            {
				try
				{
					DateTime sd = DateTime.Parse(this.StartDateTS);
					DateTime ed = DateTime.Parse(this.EndDateTS);
					return $"{sd.ToString("D")} - {ed.ToString("D")}";
				}
				catch (Exception ex) {  }
			}
			return null;
        }

		/// <summary>
		/// Returns the venue location label.
		/// </summary>
		/// <returns></returns>
		public string? LocationLabel()
        {
			return this.Venue?.ShortLocationFormatted();
        }

		/// <summary>
		/// Indicates if the news has related articles
		/// </summary>
		/// <returns></returns>
		public bool HasRelatedStories()
        {
			return this.RelatedStories != null && this.RelatedStories!.Count > 0;
        }

		/// <summary>
		/// Indicates if the rodeo has media items.
		/// </summary>
		/// <returns></returns>
		public bool HasRelatedMedia()
		{
			return this.RelatedMedia != null && this.RelatedMedia!.Count > 0;
		}

		#endregion
	}
}

