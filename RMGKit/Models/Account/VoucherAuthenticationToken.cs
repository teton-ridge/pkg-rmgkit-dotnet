using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
    public class VoucherAuthenticationToken
    {
        [JsonPropertyName("account_id")]
        public int AcctID { get; set; } = 0;
        [JsonPropertyName("account_reference")]
        public string AcctRef { get; set; } = "";
        [JsonPropertyName("email")]
        public string Email { get; set; } = "";
        [JsonPropertyName("card_data")]
        public string CardData { get; set; } = "";
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = "";
        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = "";
        [JsonPropertyName("remaining_days")]
        public int RemainingDays { get; set; } = 0;
        [JsonPropertyName("refund_amt")]
        public decimal RefundAmount { get; set; } = 0;
        public string Token { get; set; } = "";
        public string GetCardNo()
        {
            if (CardData.Length > 0)
            {
                var cardPieces=CardData.Split(',');
                if (cardPieces.Length > 0)
                { 
                    if (cardPieces[0].Length > 3)
                    {
                        return cardPieces[0][^4..];
                    }
                }
            }
            return "";
        }
        public string GetCardType()
        {
            if (CardData.Length > 0)
            {
                var cardPieces = CardData.Split(',');
                if (cardPieces.Length > 2)
                {
                    return cardPieces[2];
                }
            }
            return "";
        }
    }
}
