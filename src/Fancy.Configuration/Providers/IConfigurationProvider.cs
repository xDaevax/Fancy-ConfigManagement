using Config = Fancy.Configuration.Options;

namespace Fancy.Configuration.Providers
{
    /// <summary>
    /// Interface that exposes behaviors for a provider that handles reading / writing, and validating configuration data.
    /// </summary>
    public interface IConfigurationProvider
    {
        /// <summary>
        /// Determines whether the given <paramref name="key"/> is present in the configuration.
        /// </summary>
        /// <param name="key">The key or path to check.</param>
        /// <returns></returns>
        bool HasKey(string key);

        /// <summary>
        /// Attempts to load the configuration file located at the given <paramref name="path"/> and de-serialize it into a <see cref="Config.Configuration"/> instance.
        /// </summary>
        /// <param name="path">The fully qualified path of the configuration file.</param>
        /// <returns>The strongly-typed instance of <see cref="Config.Configuration"/> stored in the file.</returns>
        Config.Configuration Load(string path);
    }
}
