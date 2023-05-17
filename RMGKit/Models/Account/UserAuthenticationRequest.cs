using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
    public class UserAuthenticationRequest
    {
		public UserAuthenticationRequest()
		{
			this.Email = String.Empty;
			this.Password = String.Empty;
			this.Marketing = false;
			this.TargetTags = String.Empty;
			this.FirstName = String.Empty;
			this.LastName = String.Empty;
            this.Address = String.Empty;
            this.Address2 = String.Empty;
            this.City = String.Empty;
            this.State = String.Empty;
            this.Zip = String.Empty;
            this.Phone = String.Empty;
            this.Country = String.Empty;
        }


		#region Properties

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("password")]
		public string Password { get; set; }
		[JsonPropertyName("marketing")]
		public bool Marketing { get; set; }
		[JsonPropertyName("token")]
		public string? Token { get; set; }
		[JsonPropertyName("target_tags")]
		public string? TargetTags { get; set; }
		[JsonPropertyName("first_name")]
		public string? FirstName { get; set; }
		[JsonPropertyName("last_name")]
		public string? LastName { get; set; }
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        [JsonPropertyName("address2")]
        public string? Address2 { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("state")]
        public string? State { get; set; }
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        #endregion
    }
}