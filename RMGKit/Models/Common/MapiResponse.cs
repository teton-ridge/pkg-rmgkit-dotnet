using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Common
{
    public class MapiAjaxResponse
    {
        public MapiAjaxResponse()
        {
            CallResult = 0;
            ErrorMessage = string.Empty;
        }
        #region Properties

        [JsonPropertyName("callResult")]
        public int CallResult { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("data")]
        public object? Data { get; set; }
        #endregion
    }
}
