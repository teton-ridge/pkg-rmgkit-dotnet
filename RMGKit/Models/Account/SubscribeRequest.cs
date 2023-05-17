using System;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Account
{
	public class SubscribeRequest
	{
		public SubscribeRequest()
		{
			this.Token = String.Empty;
			this.Product = String.Empty;
			this.Voucher = String.Empty;
            this.Action = String.Empty;
            this.Original = String.Empty;
        }
		#region Properties
		public string Token { get; set; }
		public string Product { get; set; }
		public string Voucher { get; set; }
        public string Action { get; set; }
        public string Original { get; set; }
        #endregion
    }
}

