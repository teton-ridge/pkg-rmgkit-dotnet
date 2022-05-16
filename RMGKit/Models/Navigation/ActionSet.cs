using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Navigation
{
	/// <summary>
	/// Represents a titled sub-collection of navigation actions.
	/// </summary>
    [DataContract]
	public class ActionSet
	{
		public ActionSet()
		{
			this.Id = 0;
			this.Title = String.Empty;
		}

		#region Properties

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

		[DataMember(Name = "items")]
		public Action[]? Actions { get; set; }

		[DataMember(Name = "groups")]
		public ActionSet[]? Sets { get; set; }

		#endregion

	}

}

