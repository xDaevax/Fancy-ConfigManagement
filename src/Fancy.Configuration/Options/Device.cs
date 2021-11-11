using System;
using System.Diagnostics;

namespace Fancy.Configuration.Options
{
    /// <summary>
    /// Represents an individual set of configuration options for a device in a configuration file.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    public class Device
    {
        /// <summary>
        /// The name used to refer to the device.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the room the device is currently assigned to.
        /// </summary>
        public string AssignedTo { get; set; }

        /// <summary>
        /// Gets or sets the information about the interface the device uses to communicate.
        /// </summary>
        public DeviceInterface Interface { get; set; }

    } // end class Device
} // end namespace
