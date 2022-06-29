using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Navigation
{
	/// <summary>
	/// Represents a titled sub-collection of navigation actions.
	/// </summary>
	public class ActionSet
	{
		public ActionSet()
		{
			this.Id = 0;
			this.Title = String.Empty;
		}

		#region Properties

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("items")]
		public Action[]? Actions { get; set; }

		[JsonPropertyName("groups")]
		public ActionSet[]? Sets { get; set; }

		#endregion

	}

}

