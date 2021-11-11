using System;
using System.Diagnostics;

namespace Fancy.Configuration.Options
{
    /// <summary>
    /// Gets or sets a configuration item that describes a room.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    public class Room
    {
        /// <summary>
        /// Gets or sets the name the room.
        /// </summary>
        public string Name { get; set; }
    }
}
