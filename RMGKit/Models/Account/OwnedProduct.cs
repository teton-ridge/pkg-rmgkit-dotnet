using System;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
	/// <summary>
	/// Represents an active account subscription and any upgrade/downgrade details.
	/// </summary>
	public class OwnedProduct
	{
		public OwnedProduct()
		{
			this.Id = String.Empty;
			this.Description = String.Empty;
			this.IsOwned = false;
		}


		#region Properties

		[JsonPropertyName("product_id")]
		public string Id { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("owned")]
		public bool IsOwned { get; set; }

		[JsonPropertyName("source")]
		public string? PurchaseSource { get; set; }

		[JsonPropertyName("purchase_code")]
		public string? PurchaseCode { get; set; }

		[JsonPropertyName("subscription_id")]
		public string? SubscriptionId { get; set; }

		[JsonPropertyName("change_plan_label")]
		public string? ChangePlanDescription { get; set; }

		[JsonPropertyName("upgrade_product")]
		public string? UpgradeProductId { get; set; }

		[JsonPropertyName("downgrade_product")]
		public string? DowngradeProductId { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="forPlatform">
        /// If provided, result will only be true when the PurchaseSource matches the provided value.
        /// </param>
		/// <returns></returns>
		public bool UpgradeIsAvailable(string? forPlatform = null)
        {
			bool available = !String.IsNullOrEmpty(this.UpgradeProductId);
			if (forPlatform != null)
				return available && this.PurchaseSource?.ToLower() == forPlatform!.ToLower();
			else
				return available;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="forPlatform">
		/// If provided, result will only be true when the PurchaseSource matches the provided value.
		/// </param>
		/// <returns></returns>
		public bool DowngradeIsAvailable(string? forPlatform = null)
		{
			bool available = !String.IsNullOrEmpty(this.DowngradeProductId);
			if (forPlatform != null)
				return available && this.PurchaseSource?.ToLower() == forPlatform!.ToLower();
			else
				return available;
		}

		#endregion
	}
}

