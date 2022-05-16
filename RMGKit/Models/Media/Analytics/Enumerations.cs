using System;
namespace RMGKit.Models.Media.Analytics
{
    /// <summary>
    /// Playback event types.
    /// </summary>
    public enum PlaybackEvent
    {
        unknown = 0, 
        start = 1,
        play = 2,
        stop = 3,
        complete = 4,
        error = 10
    }

    /// <summary>
    /// Playback type.
    /// </summary>
    public enum PlaybackType
    {
        unknown = 0,
        vod = 3,
        live = 4
    }
}

