using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Event
{
	/// <summary>
	/// Represents web link for an event.
	/// </summary>
	[DataContract]
	public class EventWebLink
	{
		public EventWebLink()
		{
			this.Title = String.Empty;
		}

		#region Properties

		[DataMember(Name = "link_type")]
		public int LinkType { get; set; }

		[DataMember(Name = "link_key")]
		public int LinkKey { get; set; }

		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "url")]
		public string? Url { get; set; }

		[DataMember(Name = "image_url")]
		public string? ImageUrl { get; set; }

		[DataMember(Name = "requires_identity")]
		public int? RequiresIdentity { get; set; }

		/// <summary>
		/// Indicates if a known user is required to access the content.
		/// </summary>
		public bool UserIdentityIsRequired
        {
			get
            {
				return this.RequiresIdentity != null && this.RequiresIdentity! != 0;

			}
        }

        #endregion

        #region Methods

        #endregion
    }
}

