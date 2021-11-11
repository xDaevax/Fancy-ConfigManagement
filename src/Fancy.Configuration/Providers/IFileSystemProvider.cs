using System.IO;

namespace Fancy.Configuration.Providers
{
    /// <summary>
    /// Interfaces that exposes behavior for a cross-cutting provider that provides a layer of indirection from the file-system.
    /// </summary>
    public interface IFileSystemProvider {

        /// <summary>
        /// Determines whether the given <paramref name="path"/> exists in the file system.
        /// </summary>
        /// <param name="type">The <see cref="IOType"/> used to determine whether a file or directory is being checked.</param>
        /// <param name="path">The fully qualified path to check.</param>
        /// <returns>true if the given <paramref name="path"/> exists; false otherwise</returns>
        bool Exists(IOType type, string path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        FileStream Read(string path);
    }
}
