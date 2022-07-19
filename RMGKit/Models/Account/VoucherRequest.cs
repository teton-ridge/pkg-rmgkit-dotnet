using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
	public class VoucherRequest
	{
		public VoucherRequest()
		{
			this.ProductID = String.Empty;
			this.Token = String.Empty;
			this.VoucherID = String.Empty;
		}
		#region Properties

		[JsonPropertyName("product_id")]
		public string ProductID { get; set; }

		[JsonPropertyName("token")]
		public string Token { get; set; }

		[JsonPropertyName("voucher_id")]
		public string VoucherID { get; set; }
	
		#endregion
	}
}