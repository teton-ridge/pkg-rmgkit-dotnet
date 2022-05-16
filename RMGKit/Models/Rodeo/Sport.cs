using System;

namespace RMGKit.Models.Rodeo
{
	/// <summary>
	/// Represents an enumeration of rodeo sports.
	/// </summary>
	[Flags]
	public enum Sports
	{
		Bareback = 1 << 0,
		SteerWrestling = 1 << 1,
		TeamRopingHeader = 1 << 2,
		TeamRopingHeeler = 1 << 3,
		SaddleBronc = 1 << 4,
		TieDownRoping = 1 << 5,
		SteerRoping = 1 << 6,
		BullRiding = 1 << 7,
		BarrelRacing = 1 << 8

    }

	public static class SportsExtension
    {
        /// <summary>
        /// Return all sports.
        /// </summary>
        /// <returns></returns>
        public static Sports[] All()
        {
            return new Sports[] { 
                Sports.Bareback,
                Sports.SteerWrestling,
                Sports.TeamRopingHeader,
                Sports.TeamRopingHeeler,
                Sports.SaddleBronc,
                Sports.TieDownRoping,
                Sports.SteerRoping,
                Sports.BullRiding,
                Sports.BarrelRacing
            };
        }

        /// <summary>
        /// Returns the display label for the sport.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
		public static string Label(this Enum value)
        { 
			switch (value)
            {
                case Sports.Bareback:
                    return "Bareback Riding";
                case Sports.SteerWrestling:
                            return "Steer Wrestling";
                case Sports.TeamRopingHeader:
                            return "Team Roping (Header)";
                case Sports.TeamRopingHeeler:
                            return "Team Roping (Heeler)";
                case Sports.SaddleBronc:
                            return "Saddle Bronc Riding";
                case Sports.TieDownRoping:
                            return "Tie Down Roping";
                case Sports.SteerRoping:
                            return "Steer Roping";
                case Sports.BullRiding:
                            return "Bull Riding";
                case Sports.BarrelRacing:
                            return "Barrel Racing";
                default:
                            return "";
            }
        }
    }

}

