using System;
using System.Text.Json.Serialization;
using System.Linq;

namespace RMGKit.Models.Event
{
	/// <summary>
	/// Represents an event venue.
	/// </summary>
	public class Venue
	{
		public Venue()
		{
			this.Id = 0;
		}

		#region Properties

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("address")]
		public string? StreetAddress { get; set; }

		[JsonPropertyName("city")]
		public string? City { get; set; }

		[JsonPropertyName("state")]
		public string? State { get; set; }

		[JsonPropertyName("country")]
		public string? Country { get; set; }

		[JsonPropertyName("zip")]
		public string? PostalCode { get; set; }

		[JsonPropertyName("phone")]
		public string? Phone { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Returns a short location label containing city and/or state.
		/// </summary>
		/// <returns></returns>
		public string? ShortLocationFormatted()
        {
			return String.Join(", ", new string?[]
			{
				this.City,
				this.State
			}.Where(item => !String.IsNullOrEmpty(item)));
		}

		/// <summary>
		/// Returns a full detail location label for the venue.
		/// </summary>
		/// <returns></returns>
		public string? FullLocationFormatted()
        {
			string? shortFormat = this.ShortLocationFormatted();
			return String.Join("\n", new string?[]
			{
				this.Name,
				this.StreetAddress,
				shortFormat, 
				this.Country,
				this.PostalCode,
				this.Phone
			}.Where(item => !String.IsNullOrEmpty(item)));
		}

        #endregion
    }
}

