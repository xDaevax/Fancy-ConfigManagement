<Query Kind="Program">
  <Reference Relative="..\src\Fancy.Configuration\bin\Debug\net472\Fancy.Configuration.dll">\Fancy-ConfigManagement\src\Fancy.Configuration\bin\Debug\net472\Fancy.Configuration.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Fancy.Configuration.Providers</Namespace>
  <Namespace>Fancy.Configuration.Options</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

void Main() {
    var filePath = Path.Combine(LINQPad.Util.MyQueriesFolder, "systemConfig.json");
    var fsProvider = new SimpleFileSystemProvider();
    var configProvider = new NewtonsoftConfigurationProvider(fsProvider);
   
    
    var data = configProvider.Load(filePath);
    
    data.Dump();
    data.Devices.FirstOrDefault().Name = "Device 2";
    
    data.Dump("Mutated in memory");
    
    var data2 = configProvider.Load(filePath);
    
    data2.Dump("re-read from config");
    
    
    /*cfg.Devices = new List<Device>() {
        new Device() {
            AssignedTo = "Room 1",
            Name = "Device 1",
            Interface = new DeviceInterface() {
                Type = new InterfaceType() {
                    Name = "REST"
                }
            }
        }
    };

    var serializer = new JsonSerializer();
    var builder = new StringBuilder();
    using (var textWriter = new StringWriter(builder)) {
        using (var writer = new JsonTextWriter(textWriter)) {
            serializer.Serialize(textWriter, cfg);
        }
    }
    
    var fileContents = builder.ToString();
    
    File.WriteAllText(filePath, fileContents);
    */
}

// You can define other methods, fields, classes and namespaces here