using System.IO;
using Newtonsoft.Json;

namespace Fancy.Configuration.Providers
{
    /// <summary>
    /// Leverages JSON.Net to load / manage configuration file data.
    /// </summary>
    public class NewtonsoftConfigurationProvider : IConfigurationProvider
    {
        private readonly IFileSystemProvider _fileSystemProvider;
        private readonly object _fileLock;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewtonsoftConfigurationProvider"/> class.
        /// </summary>
        /// <param name="fileSystemProvider">The <see cref="IFileSystemProvider"/> instance used to manage IO from disk.</param>
        public NewtonsoftConfigurationProvider(IFileSystemProvider fileSystemProvider)
        {
            _fileSystemProvider = fileSystemProvider;
            _fileLock = new object();
        }

        /// <inheritdoc />
        public bool HasKey(string key)
        {
            return true;
        }

        /// <inheritdoc />
        public Options.Configuration Load(string path)
        {
            var fileExists = FileSystemProvider.Exists(IOType.File, path);
            if (fileExists)
            {
                lock(_fileLock)
                {
                    var configContents = string.Empty;
                    if (fileExists)
                    {
                        using (FileStream contents = FileSystemProvider.Read(path))
                        {
                            using (var streamReader = new StreamReader(contents))
                            {
                                configContents = streamReader.ReadToEnd();
                            }
                        }

                        using (var reader = new StringReader(configContents))
                        {
                            using (var jsonTextReader = new JsonTextReader(reader))
                            {
                                var serializer = JsonSerializer.CreateDefault(GetSettings());
                                Options.Configuration returnValue = serializer.Deserialize<Options.Configuration>(jsonTextReader);

                                return returnValue;
                            }
                        }
                    } else
                    {
                        throw new FileNotFoundException("Unable to load the configuration file.", path);
                    }
                }
            } else
            {
                throw new FileNotFoundException("Unable to load the configuration file.", path);
            }
        }

        /// <summary>
        /// Returns a consistent set of serializer settings.
        /// </summary>
        /// <returns></returns>
        protected JsonSerializerSettings GetSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };

            return settings;
        }

        /// <summary>
        /// Gets the injected <see cref="IFileSystemProvider"/> instance used to manage IO to and from disk.
        /// </summary>
        protected IFileSystemProvider FileSystemProvider => _fileSystemProvider;
    }
}
