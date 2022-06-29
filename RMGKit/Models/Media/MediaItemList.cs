using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a collection of media items.
	/// </summary>
	public class MediaItemList: List<MediaItem>
	{
		public MediaItemList()
		{
		}
	}
}

