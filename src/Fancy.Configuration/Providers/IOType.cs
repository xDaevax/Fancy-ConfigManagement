using System;

namespace Fancy.Configuration.Providers
{
    /// <summary>
    /// Enumeration used by the file system namespace to differentiate between directories and files for location and loading.
    /// </summary>
    [Serializable]
    public enum IOType : int
    {
        /// <summary>
        /// Not used in normal code.  The default value.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Indicates a file is being targeted.
        /// </summary>
        File = 1,

        /// <summary>
        /// Indicates a directory is being targeted.
        /// </summary>
        Directory = 2,

        /// <summary>
        /// Indicates a UNC-style path is being targeted.
        /// </summary>
        Remote = 3
    }
}
