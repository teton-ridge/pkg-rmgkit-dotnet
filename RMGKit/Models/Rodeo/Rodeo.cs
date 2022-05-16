using System;
using System.Runtime.Serialization;
using RMGKit.Models.Event;
using RMGKit.Models.News;
using RMGKit.Models.Media;

namespace RMGKit.Models.Rodeo
{
	/// <summary>
	/// Represents a rodeo event.
	/// </summary>
	[DataContract]
	public class Rodeo
	{
		public Rodeo()
		{
			this.Id = 0;
			this.Name = "";
		}

		#region Properties

		[DataMember(Name = "rodeo_id")]
		public int Id { get; set; }

		[DataMember(Name = "rodeo_name")]
		public string Name { get; set; }

		[DataMember(Name = "start_date")]
		public string? StartDateTS { get; set; }

		[DataMember(Name = "end_date")]
		public string? EndDateTS { get; set; }

		[DataMember(Name = "season")]
		public int? Season { get; set; }

		[DataMember(Name = "venue")]
		public Venue? Venue { get; set; }

		[DataMember(Name = "logo_url")]
		public string? LogoUrl { get; set; }

		[DataMember(Name = "tickets_url")]
		public string? TicketsUrl { get; set; }

		[DataMember(Name = "description")]
		public string? DescriptionHtml { get; set; }

		[DataMember(Name = "results_html")]
		public string? ResultsHtml { get; set; }

		[DataMember(Name = "live_id")]
		public string? LiveStreamId { get; set; }

		[DataMember(Name = "related_stories")]
		public ArticleList? RelatedStories { get; set; }

		[DataMember(Name = "media")]
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

