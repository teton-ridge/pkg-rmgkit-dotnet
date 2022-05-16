using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Schedule
{
	/// <summary>
	/// Represents an individual program within the TV schedule.
	/// </summary>
	[DataContract]
	public class TVScheduleShow
	{
		public TVScheduleShow()
		{
			this.Id = String.Empty;
			this.Title = String.Empty;
			this.AirDateTS = String.Empty;
		}

		#region Properties

		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "airdate")]
		public string AirDateTS { get; set; }

		[DataMember(Name = "airdate")]
		public string? Season { get; set; }

		[DataMember(Name = "episode")]
		public string? Episode { get; set; }

		[DataMember(Name = "rating")]
		public string? Rating { get; set; }

		[DataMember(Name = "tease")]
		public string? Tease { get; set; }

		[DataMember(Name = "synopsis")]
		public string? Synopsis { get; set; }

		[DataMember(Name = "thumb")]
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

