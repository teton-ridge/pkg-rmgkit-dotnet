using System;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Account
{
	public class CancelRenewRequest
	{
		public CancelRenewRequest()
		{
			this.AccountReference = String.Empty;
			this.SubscriptionReference = String.Empty;
			this.ReasonCode = 0;
			this.ReasonDescription = String.Empty;
			this.ProductID = 0;
			this.PaymentMethod = String.Empty;
		}
		#region Properties
		[JsonPropertyName("account_reference")]
		public string AccountReference { get; set; }
		[JsonPropertyName("subscription_reference")]
		public string SubscriptionReference { get; set; }
		[JsonPropertyName("reason_code")]
		public long ReasonCode { get; set; }
		[JsonPropertyName("reason_description")]
		public string ReasonDescription { get; set; }
		[JsonPropertyName("product_id")]
		public long ProductID { get; set; }
		[JsonPropertyName("payment_method")]
		public string PaymentMethod { get; set; }
		#endregion
	}
}
