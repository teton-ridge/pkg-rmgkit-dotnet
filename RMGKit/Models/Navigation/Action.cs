using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Navigation
{
	/// <summary>
	/// Represents an individual navigation action.
	/// </summary>
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

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("type")]
		public ActionType Type { get; set; }

		[JsonPropertyName("caption")]
		public string Caption { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("subtitle")]
		public string? SubTitle { get; set; }

		[JsonPropertyName("icon")]
		public string? Icon { get; set; }

		[JsonPropertyName("data")]
		public string? Data { get; set; }

		#endregion
	}

}