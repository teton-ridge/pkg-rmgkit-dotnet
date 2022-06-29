using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace RMGKit.Models.Standing
{
	/// <summary>
	/// Represents a standings group for a specific organization and region/circuit.
	/// </summary>
	public class StandingGroup
	{
		public StandingGroup()
		{
			this.Id = 0;
			this.Name = String.Empty;
		}

		#region Properties

		[JsonPropertyName("standing_group_id")]
		public int Id { get; set; }

		[JsonPropertyName("group_name")]
		public string Name { get; set; }

		[JsonPropertyName("organization")]
		public string? Organization { get; set; }

		[JsonPropertyName("available_years")]
		public List<int>? AvailableYears { get; set; }

		[JsonPropertyName("events")]
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

