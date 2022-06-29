using System;
using System.Text.Json.Serialization;
using RMGKit.Models.Athlete;

namespace RMGKit.Models.Standing
{
	/// <summary>
	/// Represents an individual standing within an event.
	/// </summary>
	public class Standing
	{
		public Standing()
		{
			this.AthleteId = 0;
			this.AthleteName = string.Empty;
			this.Rank = 0;
			this.Earnings = 0.0;
		}


		#region Properties

		[JsonPropertyName("athlete_id")]
		public int AthleteId { get; set; }

		[JsonPropertyName("athlete_name")]
		public string AthleteName { get; set; }

		[JsonPropertyName("athlete_city")]
		public string? AthleteCity { get; set; }

		[JsonPropertyName("athlete_state")]
		public string? AthleteState { get; set; }

		[JsonPropertyName("rank")]
		public int Rank { get; set; }

		[JsonPropertyName("earnings")]
		public double Earnings { get; set; }

		[JsonPropertyName("year")]
		public int? Year { get; set; }

		[JsonPropertyName("event_id")]
		public int? EventId { get; set; }

		[JsonPropertyName("event_name")]
		public string? EventName { get; set; }

		[JsonPropertyName("group_id")]
		public int? GroupId { get; set; }

		[JsonPropertyName("group_name")]
		public string? GroupName { get; set; }

		public Athlete.Athlete Athlete
        {
			get
            {
				Athlete.Athlete athlete = new Athlete.Athlete();
				athlete.Id = this.AthleteId;
				athlete.FullName = this.AthleteName;
				athlete.City = this.AthleteCity;
				athlete.State = this.AthleteState;

				return athlete;
			}
        }

		#endregion

		#region Methods

		/// <summary>
		/// Returns formatted earnings.
		/// </summary>
		/// <returns></returns>
		public string EarningsFormatted()
        {
			return this.Earnings.ToString("C");
        }

        #endregion
    }
}

