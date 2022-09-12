using MySqlX.XDevAPI;

namespace MySqlX.Security;

internal class ExternalAuthenticationPlugin
{
	private MySqlXConnectionStringBuilder _settings;

	public string PluginName => "External Authentication Plugin";

	public string AuthName => "EXTERNAL";

	public ExternalAuthenticationPlugin(MySqlXConnectionStringBuilder settings)
	{
		_settings = settings;
	}
}
