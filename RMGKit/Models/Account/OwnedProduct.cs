using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Account
{
	/// <summary>
	/// Represents an active account subscription and any upgrade/downgrade details.
	/// </summary>
	[DataContract]
	public class OwnedProduct
	{
		public OwnedProduct()
		{
			this.Id = String.Empty;
			this.Description = String.Empty;
			this.IsOwned = false;
		}


		#region Properties

		[DataMember(Name = "product_id")]
		public string Id { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "owned")]
		public bool IsOwned { get; set; }

		[DataMember(Name = "source")]
		public string? PurchaseSource { get; set; }

		[DataMember(Name = "purchase_code")]
		public string? PurchaseCode { get; set; }

		[DataMember(Name = "subscription_id")]
		public string? SubscriptionId { get; set; }

		[DataMember(Name = "change_plan_label")]
		public string? ChangePlanDescription { get; set; }

		[DataMember(Name = "upgrade_product")]
		public string? UpgradeProductId { get; set; }

		[DataMember(Name = "downgrade_product")]
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

