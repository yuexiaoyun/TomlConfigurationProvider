using Microsoft.Extensions.Configuration;

namespace IrobotBox.Configuration.Toml
{
    public class TomlConfigurationSource : FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            FileProvider = FileProvider ?? builder.GetFileProvider();
            return new TomlConfigurationProvider(this);
        }
    }
}
