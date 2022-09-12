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
			more = 100,
			header_menu = 200,
			footer_menu = 201,
			goto_page = 202,
			new_page_link = 203,
			iframe = 204,
			top_level_menu=205
		}

		public Action()
		{
			this.Id = 0;
			this.Type = ActionType.none;
			this.Caption = string.Empty;
			this.MenuClass = string.Empty;
		}

		#region Properties

		[JsonPropertyName("element_id")]
		public int Id { get; set; }

		[JsonPropertyName("item_action_id")]
		public ActionType Type { get; set; }

		[JsonPropertyName("item_class")]
		public string MenuClass { get; set; }

		[JsonPropertyName("item_caption")]
		public string Caption { get; set; }

		[JsonPropertyName("item_title")]
		public string? Title { get; set; }

		[JsonPropertyName("item_icon")]
		public string? Icon { get; set; }

		[JsonPropertyName("item_data")]
		public string? Data { get; set; }

		[JsonPropertyName("children")]
		public System.Collections.Generic.List<RMGKit.Models.Navigation.Action>? Children { get; set; }

		#endregion
	}

}