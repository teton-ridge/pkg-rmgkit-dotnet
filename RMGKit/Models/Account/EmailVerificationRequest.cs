using RMGKit.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RMGKit.Models.Account
{
    public class EmailVerificationRequest
    {
       
       public EmailVerificationRequest(Int64 customerID=0, string token = "") {
            Token = token;
            CustomerID = customerID;
        }
        [JsonPropertyName("token")]
        public string Token { get; set; } = "";
        [JsonPropertyName("customer_id")]
        public Int64 CustomerID { get; set; } = 0;
        [JsonPropertyName("email")]
        public string Email { get; set; } = "";

    }
}
