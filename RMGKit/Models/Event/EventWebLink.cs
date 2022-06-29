using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Event
{
	/// <summary>
	/// Represents web link for an event.
	/// </summary>
	public class EventWebLink
	{
		public EventWebLink()
		{
			this.Title = String.Empty;
		}

		#region Properties

		[JsonPropertyName("link_type")]
		public int LinkType { get; set; }

		[JsonPropertyName("link_key")]
		public int LinkKey { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("url")]
		public string? Url { get; set; }

		[JsonPropertyName("image_url")]
		public string? ImageUrl { get; set; }

		[JsonPropertyName("requires_identity")]
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

