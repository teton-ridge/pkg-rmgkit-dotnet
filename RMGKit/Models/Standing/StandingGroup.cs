using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace RMGKit.Models.Standing
{
	/// <summary>
	/// Represents a standings group for a specific organization and region/circuit.
	/// </summary>
	[DataContract]
	public class StandingGroup
	{
		public StandingGroup()
		{
			this.Id = 0;
			this.Name = String.Empty;
		}

		#region Properties

		[DataMember(Name = "standing_group_id")]
		public int Id { get; set; }

		[DataMember(Name = "group_name")]
		public string Name { get; set; }

		[DataMember(Name = "organization")]
		public string? Organization { get; set; }

		[DataMember(Name = "available_years")]
		public List<int>? AvailableYears { get; set; }

		[DataMember(Name = "events")]
		public StandingEventList? Events { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates if there are events present.
		/// </summary>
		/// <returns></returns>
		public bool HasEvents()
        {
			return (this.Events?.Count ?? 0) > 0;
        }

		/// <summary>
		/// Indicates if there are standings available for the given year.
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		public bool IsAvailableForYear(int year)
        {
			return this.AvailableYears?.Contains(year) ?? false;
        }

        #endregion
    }
}

