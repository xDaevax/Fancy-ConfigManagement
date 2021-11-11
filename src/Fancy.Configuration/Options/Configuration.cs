using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Fancy.Configuration.Options
{
    /// <summary>
    /// Represents the top-level of a configuration structure.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    public class Configuration
    {
        /// <summary>
        /// Gets or sets the collection of <see cref="Device"/> instances in the configuration.
        /// </summary>
        public IEnumerable<Device> Devices { get; set; }
    }
}
