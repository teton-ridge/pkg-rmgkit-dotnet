using System;
using System.Text.Json.Serialization;
using System.Linq;
using RMGKit.Models.Rodeo;

namespace RMGKit.Models.Athlete
{
	/// <summary>
	/// Represents an individual athlete.
	/// </summary>
	public class Athlete
	{
		public Athlete()
		{
			this.Id = 0;
		}

		#region Properties

		[JsonPropertyName("athlete_id")]
		public int Id { get; set; }

		[JsonPropertyName("image_url")]
		public string? ImageUrl { get; set; }

		[JsonPropertyName("first_name")]
		public string? FirstName { get; set; }

		[JsonPropertyName("last_name")]
		public string? LastName { get; set; }

		[JsonPropertyName("athlete_name")]
		public string? FullName { get; set; }

		[JsonPropertyName("birthday")]
		public string? BirthDay { get; set; }

		[JsonPropertyName("birthplace")]
		public string? BirthPlace { get; set; }

		[JsonPropertyName("city")]
		public string? City { get; set; }

		[JsonPropertyName("city")]
		public string? State { get; set; }

		[JsonPropertyName("highlights")]
		public string? Highlights { get; set; }

		[JsonPropertyName("events")]
		public Sports? Events { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Returns the appropriate combo of city and state for display as 'Hometown'.
		/// </summary>
		/// <returns></returns>
		public string? HomeTown()
        {
			return String.Join(", ", new string?[]
			{
				this.City,
				this.State
			}.Where(item => !String.IsNullOrEmpty(item)));
        }

		/// <summary>
		/// Returns a date of birth label.
		/// </summary>
		/// <returns></returns>
		public string? DateOfBirthFormatted()
        {
			string? output = null;
			if (this.BirthDay != null)
            {
				try
                {
					DateTime bd = DateTime.Parse(this.BirthDay);
					output = bd.ToString("D");
				}
				catch(Exception ex) { output = null; }
            }
			return output;
        }

        #endregion
    }
}

