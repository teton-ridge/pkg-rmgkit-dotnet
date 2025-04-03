using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace RMGKit.Models.Content
{
	/// <summary>
	/// Represents a content page
	/// </summary>
	public class Page
	{
		public Page()
		{
            NavigationSetName = String.Empty;
            NavigationSetID = 0;
            ContentStrings = new Dictionary<string, string>();
        }

		#region Properties
		[JsonPropertyName("title")]
		public string? Title { get; set; }

        [JsonPropertyName("blocks")]
        public List<Block>? Blocks { get; set; }

        [JsonPropertyName("navigation")]
        public RMGKit.Models.Navigation.Navigation? Navigation { get; set; }
        
        [JsonPropertyName("content_strings")]
        [XmlIgnore]
        public Dictionary<string,string> ContentStrings { get; set; }


        [JsonPropertyName("navigation_set_name")]
        public string NavigationSetName { get; set; }
        [JsonPropertyName("navigation_set_id")]
        public long NavigationSetID { get; set; }
        #endregion

        #region Methods

        ///// <summary>
        ///// Indicates if any media items are available.
        ///// </summary>
        ///// <returns></returns>
        public int BlockCount()
        {
            if (this.Blocks != null)
                return Blocks.Count;
            else
                return 0;
        }

        public int NavCount()
        {
            if (this.Navigation != null)
                return Navigation.Count;
            else
                return 0;
        }
        #endregion
    }
}

