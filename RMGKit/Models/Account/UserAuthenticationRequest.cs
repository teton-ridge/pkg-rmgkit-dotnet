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
			this.FirstName = "";
			this.LastName = "";
            this.Address = "";
            this.Address2 = "";
            this.City = "";
            this.State = "";
            this.Zip = "";
            this.Phone = "";
            this.Country = "";
            this.FormToken = "";
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
        [JsonPropertyName("form_token")]
        public string? FormToken { get; set; }
        #endregion
    }
}