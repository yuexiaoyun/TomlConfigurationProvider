using Microsoft.Extensions.Configuration;
using System.IO;

namespace IrobotBox.Configuration.Toml
{
    public class TomlConfigurationProvider : FileConfigurationProvider
    {
        public TomlConfigurationProvider(TomlConfigurationSource source) : base(source) { }
        public override void Load(Stream stream)
        {
            var parser = new TomlConfigurationFileParser();
            Data = parser.Parse(stream);
        }
    }
}
