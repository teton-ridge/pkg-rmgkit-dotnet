using System;
using System.Text.Json.Serialization;
using RMGKit.Models.Navigation;
using RMGKit.Models.Media;
using RMGKit.Models.News;
using RMGKit.Models.Rodeo;
using RMGKit.Models.Standing;
using RMGKit.Models.Athlete;
using RMGKit.Models.Event;

namespace RMGKit.Models.Common
{
	/// <summary>
	/// Represents a container that may contain various types of content.
	/// </summary>
	public class ContentNode
	{
        /// <summary>
        /// Represents a content node type.
        /// </summary>
        public enum NodeType: int {
            unknown = 0,
            media = 1,
            news = 2,
            rodeos = 3,
            standings = 4,
            athletes = 5,
            eventLink = 6,
            scoreboard = 7
        }

        public ContentNode()
		{
            this.Type = NodeType.unknown;
            this.Module = Navigation.Action.ActionType.none;
		}

        #region Properties

        [JsonPropertyName("node_type")]
        public NodeType Type { get; set; }

        [JsonPropertyName("module_id")]
        public Navigation.Action.ActionType Module { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("link_text")]
        public string? LinkText { get; set; }

        [JsonPropertyName("link_text")]
        public string? URL { get; set; }

        [JsonPropertyName("media")]
        public MediaItemList? MediaItems { get; set; }

        [JsonPropertyName("news")]
        public ArticleList? NewsItems { get; set; }

        [JsonPropertyName("rodeos")]
        public RodeoList? RodeoItems { get; set; }

        [JsonPropertyName("standings")]
        public StandingGroupSetList? StandingItems { get; set; }

        [JsonPropertyName("event_links")]
        public EventWebLinkList? EventLinkItems { get; set; }

        [JsonPropertyName("athletes")]
        public Athlete.AthleteList? AthleteItems { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the number of contained content items.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            switch (this.Type)
            {
                case NodeType.media:
                    return this.MediaItems?.Count ?? 0;
                case NodeType.news:
                    return this.NewsItems?.Count ?? 0;
                case NodeType.rodeos:
                    return this.RodeoItems?.Count ?? 0;
                case NodeType.standings:
                    if ((this.StandingItems?.Count ?? 0) > 0) {
                        return this.StandingItems?[0].Groups?[0]?.Events?.Count ?? 0;
                    }
                    return 0;
                case NodeType.scoreboard:
                    if ((this.StandingItems?.Count ?? 0) > 0)
                    {
                        return this.StandingItems?[0].Groups?[0]?.Events?.Count ?? 0;
                    }
                    return 0;
                case NodeType.eventLink:
                    return this.EventLinkItems?.Count ?? 0;
                case NodeType.athletes:
                        return this.AthleteItems?.Count ?? 0;
                default:
                        return 0;
            }
        }

        #endregion
    }
}

