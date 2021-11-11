using System;
using System.IO;

namespace Fancy.Configuration.Providers
{
    /// <summary>
    /// Basic implementation of a disk IO provider.
    /// </summary>
    public class SimpleFileSystemProvider : IFileSystemProvider
    {
        /// <inheritdoc />
        public bool Exists(IOType type, string path)
        {
            bool returnValue;
            switch (type)
            {
                case IOType.Directory:
                    returnValue = Directory.Exists(path);
                    break;
                case IOType.File:
                    returnValue = File.Exists(path);
                    break;
                case IOType.Remote:
                    returnValue = Directory.Exists(path);
                    break;
                default:
                    throw new ArgumentException("Unknown IO Type", nameof(type));
            }

            return returnValue;
        }

        /// <inheritdoc />
        public FileStream Read(string path)
        {
            return File.OpenRead(path);
        }
    }
}
