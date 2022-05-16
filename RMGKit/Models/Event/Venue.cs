using System;
using System.Runtime.Serialization;
using System.Linq;

namespace RMGKit.Models.Event
{
	/// <summary>
	/// Represents an event venue.
	/// </summary>
	[DataContract]
	public class Venue
	{
		public Venue()
		{
			this.Id = 0;
		}

		#region Properties

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "name")]
		public string? Name { get; set; }

		[DataMember(Name = "address")]
		public string? StreetAddress { get; set; }

		[DataMember(Name = "city")]
		public string? City { get; set; }

		[DataMember(Name = "state")]
		public string? State { get; set; }

		[DataMember(Name = "country")]
		public string? Country { get; set; }

		[DataMember(Name = "zip")]
		public string? PostalCode { get; set; }

		[DataMember(Name = "phone")]
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

