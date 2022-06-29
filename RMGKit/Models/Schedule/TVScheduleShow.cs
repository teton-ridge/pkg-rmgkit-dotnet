using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Schedule
{
	/// <summary>
	/// Represents an individual program within the TV schedule.
	/// </summary>
	public class TVScheduleShow
	{
		public TVScheduleShow()
		{
			this.Id = String.Empty;
			this.Title = String.Empty;
			this.AirDateTS = String.Empty;
		}

		#region Properties

		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("airdate")]
		public string AirDateTS { get; set; }

		[JsonPropertyName("airdate")]
		public string? Season { get; set; }

		[JsonPropertyName("episode")]
		public string? Episode { get; set; }

		[JsonPropertyName("rating")]
		public string? Rating { get; set; }

		[JsonPropertyName("tease")]
		public string? Tease { get; set; }

		[JsonPropertyName("synopsis")]
		public string? Synopsis { get; set; }

		[JsonPropertyName("thumb")]
		public string? ImageUrl { get; set; }

        #endregion

        #region Private Methods

		private DateTime? AirTimeAsDate()
        {
			try
			{
				return DateTime.Parse(this.AirDateTS);
			}
			catch (Exception ex) { return null; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Returns formatted air time label.
		/// </summary>
		/// <returns></returns>
		public string AirTimeFormatted()
        {
			DateTime? at = this.AirTimeAsDate();
			if (at != null)
            {
				return at.Value.ToString("t");
            }
			return String.Empty;
        }

		/// <summary>
		/// Returns formatted full air date and time label.
		/// </summary>
		/// <returns></returns>
		public string AirDateTimeFormatted()
		{
			DateTime? at = this.AirTimeAsDate();
			if (at != null)
			{
				return at.Value.ToString("f");
			}
			return String.Empty;
		}

		/// <summary>
		/// Returns a detail label containing episode, season, etc.
		/// </summary>
		/// <returns></returns>
		public string DetailFormatted()
        {
			string? s = !String.IsNullOrEmpty(this.Season) ? $"Season: {this.Season}" : String.Empty;
			string? e = !String.IsNullOrEmpty(this.Episode) ? $"Episode: {this.Episode}" : String.Empty;
			string? r = !String.IsNullOrEmpty(this.Rating) ? $"Rating: {this.Rating}" : String.Empty;

			return $"{s} {e} {r}";
        }

		#endregion
	}
}

