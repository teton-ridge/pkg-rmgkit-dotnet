using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Standing
{
	/// <summary>
	/// Represents a set of standing groups for a given year.
	/// </summary>
	public class StandingGroupSet
	{
		public StandingGroupSet()
		{
			this.Year = 0;
		}

		#region Properties

		[JsonPropertyName("year")]
		public int Year { get; set; }

		[JsonPropertyName("groups")]
		public StandingGroupList? Groups { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates if there are standing groups present.
		/// </summary>
		/// <returns></returns>
		public bool HasGroups()
        {
			return (this.Groups?.Count ?? 0) > 0;
        }

        #endregion
    }
}

