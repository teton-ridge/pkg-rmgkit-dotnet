using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a collection of media items groups. Such as episodes or a show.
	/// </summary>
	public class MediaGroup
	{
		public MediaGroup()
		{
			this.Id = 0;
		}

		#region Properties

		[DataMember(Name = "season_id")]
		public int Id { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

		[DataMember(Name = "summary")]
		public string? Summary { get; set; }

		[DataMember(Name = "thumb_url")]
		public string? ImageURL { get; set; }

		[DataMember(Name = "episodes")]
		public MediaGroupList? Items{ get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates the number of media items available.
		/// </summary>
		/// <returns></returns>
		public int Count()
        {
			return this.Items?.Count ?? 0;
        }

        #endregion
    }
}

