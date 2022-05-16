using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Navigation
{
	/// <summary>
	/// Represents an individual navigation action.
	/// </summary>
	[DataContract]
	public class Action
	{
		/// <summary>
		/// Defines the available navigation action types.
		/// </summary>
		public enum ActionType : int
		{
			none = -1,
			header = 0,
			news = 1,
			rodeos = 2,
			stadings = 3,
			videos = 4,
			subscription = 5,
			account = 6,
			schedule = 7,
			shows = 8,
			athletes = 9,
			rodeo101 = 10,
			shop = 11,
			tickets = 12,
			prca = 13,
			livetv = 14,
			nfr = 15,
			scoreboard = 16,
			market = 17,
			special_event = 20,
			web = 98,
			url = 99,
			more = 100
		}

		public Action()
		{
			this.Id = 0;
			this.Type = ActionType.none;
			this.Caption = string.Empty;
		}

		#region Properties

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "type")]
		public ActionType Type { get; set; }

		[DataMember(Name = "caption")]
		public string Caption { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

		[DataMember(Name = "subtitle")]
		public string? SubTitle { get; set; }

		[DataMember(Name = "icon")]
		public string? Icon { get; set; }

		[DataMember(Name = "data")]
		public string? Data { get; set; }

		#endregion
	}

}