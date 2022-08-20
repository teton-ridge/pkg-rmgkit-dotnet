using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
    public class FollowListRequest
    {
		#region Properties

		[JsonPropertyName("email")]
		public string Email { get; set; } = "";

		[JsonPropertyName("item_id")]
		public long ItemID { get; set; } = 0;

		[JsonPropertyName("item_type")]
		public long ItemType { get; set; } = 0;

		[JsonPropertyName("image_type")]
		public long ImageType { get; set; } = 0;

	
		#endregion
    }
}
