using System;
using System.Diagnostics;

namespace Fancy.Configuration.Options
{
    /// <summary>
    /// Represents an interface of a device defined in a configuration file.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    public class DeviceInterface
    {
        /// <summary>
        /// Gets or sets the <see cref="InterfaceType"/> that describes the low-level configuration of the interface.
        /// </summary>
        public InterfaceType Type { get; set; }
    } // end class DeviceInterface
}
