using System;
namespace RMGKit.Models.Schedule
{
	/// <summary>
	/// Represents a grouping of scheduled shows for a specific day.
	/// </summary>
	public class TVScheduleDay
	{
		public DateTime Day;
		public TVScheduleShowList Shows;

		public TVScheduleDay()
		{
			this.Day = DateTime.Now;
			this.Shows = new TVScheduleShowList();
		}

		public TVScheduleDay(DateTime day)
		{
			this.Day = day;
			this.Shows = new TVScheduleShowList();
		}

		public TVScheduleDay(DateTime day, TVScheduleShowList shows)
		{
			this.Day = day;
			this.Shows = shows;
		}

		#region Methods

		/// <summary>
		/// Returns the date formatted for display.
		/// </summary>
		/// <returns></returns>
		public string DayFormatted()
        {
			return this.Day.ToString("D");
		}

        #endregion
    }
}

