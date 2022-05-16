using System;
using System.Runtime.Serialization;
using RMGKit.Models.Athlete;

namespace RMGKit.Models.Standing
{
	/// <summary>
	/// Represents an individual standing within an event.
	/// </summary>
	[DataContract]
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

		[DataMember(Name = "athlete_id")]
		public int AthleteId { get; set; }

		[DataMember(Name = "athlete_name")]
		public string AthleteName { get; set; }

		[DataMember(Name = "athlete_city")]
		public string? AthleteCity { get; set; }

		[DataMember(Name = "athlete_state")]
		public string? AthleteState { get; set; }

		[DataMember(Name = "rank")]
		public int Rank { get; set; }

		[DataMember(Name = "earnings")]
		public double Earnings { get; set; }

		[DataMember(Name = "year")]
		public int? Year { get; set; }

		[DataMember(Name = "event_id")]
		public int? EventId { get; set; }

		[DataMember(Name = "event_name")]
		public string? EventName { get; set; }

		[DataMember(Name = "group_id")]
		public int? GroupId { get; set; }

		[DataMember(Name = "group_name")]
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

