using System;
using System.Runtime.Serialization;
using System.Linq;
using RMGKit.Models.Rodeo;

namespace RMGKit.Models.Athlete
{
	/// <summary>
	/// Represents an individual athlete.
	/// </summary>
	[DataContract]
	public class Athlete
	{
		public Athlete()
		{
			this.Id = 0;
		}

		#region Properties

		[DataMember(Name = "athlete_id")]
		public int Id { get; set; }

		[DataMember(Name = "image_url")]
		public string? ImageUrl { get; set; }

		[DataMember(Name = "first_name")]
		public string? FirstName { get; set; }

		[DataMember(Name = "last_name")]
		public string? LastName { get; set; }

		[DataMember(Name = "athlete_name")]
		public string? FullName { get; set; }

		[DataMember(Name = "birthday")]
		public string? BirthDay { get; set; }

		[DataMember(Name = "birthplace")]
		public string? BirthPlace { get; set; }

		[DataMember(Name = "city")]
		public string? City { get; set; }

		[DataMember(Name = "city")]
		public string? State { get; set; }

		[DataMember(Name = "highlights")]
		public string? Highlights { get; set; }

		[DataMember(Name = "events")]
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

