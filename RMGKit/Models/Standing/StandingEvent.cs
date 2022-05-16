using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace RMGKit.Models.Standing
{
	/// <summary>
	/// Represents an individual standing event.
	/// </summary>
	[DataContract]
	public class StandingEvent
	{
		public StandingEvent()
		{
			this.Id = 0;
			this.Name = String.Empty;
		}

		#region Properties

		[DataMember(Name = "event_id")]
		public int Id { get; set; }

		[DataMember(Name = "event_name")]
		public string Name { get; set; }

		[DataMember(Name = "standings")]
		public StandingList? Standings { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates if there are standings present.
		/// </summary>
		/// <returns></returns>
		public bool HasStandings()
        {
			return (this.Standings?.Count ?? 0) > 0;
        }

        #endregion
    }
}

