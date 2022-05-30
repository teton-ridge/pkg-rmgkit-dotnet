using System;
using System.Runtime.Serialization;

namespace RMGKit.Models.Media
{
	/// <summary>
	/// Represents a grouping of shows or media items.
	/// </summary>
	[DataContract]
	public class MediaCategory
	{
		public MediaCategory()
		{
		}

		#region Properties

		[DataMember(Name = "genre_id")]
		public int Id { get; set; }

		[DataMember(Name = "title")]
		public string? Title { get; set; }

        [DataMember(Name = "shows")]
        public ShowList? Shows { get; set; }

        [DataMember(Name = "episodes")]
        public MediaItemList? MediaItems { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Indicates the number of shows available.
        /// </summary>
        /// <returns></returns>
        public int ShowCount()
        {
            return this.Shows?.Count ?? 0;
        }

        ///// <summary>
        ///// Indicates the number of media items available.
        ///// </summary>
        ///// <returns></returns>
        public int MediaItemCount()
        {
            return this.MediaItems?.Count ?? 0;
        }

        ///// <summary>
        ///// Indicates if any media items are available.
        ///// </summary>
        ///// <returns></returns>
        public bool HasMediaItems()
        {
            return this.MediaItems != null;
        }

        #endregion
    }
}

