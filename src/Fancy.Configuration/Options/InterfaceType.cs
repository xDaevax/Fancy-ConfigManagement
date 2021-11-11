using System;
using System.Diagnostics;

namespace Fancy.Configuration.Options
{
    /// <summary>
    /// Represents the specific configuration options for a type of interface.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    public class InterfaceType
    {
        /// <summary>
        /// Gets or sets the name that describes the interface (ex: TCP, REST, Serial).
        /// </summary>
        public string Name { get; set; }
    }
}
