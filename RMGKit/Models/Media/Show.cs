using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a specific 'show' or collection of media item groups.
	/// </summary>
	[DataContract]
	public class Show
	{
		public Show()
		{
			this.Id = 0;
		}

		#region Properties

		[DataMember(Name = "show_id")]
		public int Id { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

		[DataMember(Name = "summary")]
		public string? Summary { get; set; }

		[DataMember(Name = "thumb_url")]
		public string? ImageURL { get; set; }

		[DataMember(Name = "seasons")]
		public MediaGroupList? Groups { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates the number of media item groups available.
		/// </summary>
		/// <returns></returns>
		public int GroupCount()
        {
			return this.Groups?.Count ?? 0;
        }

        #endregion
    }
}

