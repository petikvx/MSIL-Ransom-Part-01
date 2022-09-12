using System.Text;
using MySql.Data.MySqlClient.Authentication;
using MySqlX.XDevAPI;

namespace MySqlX.Security;

internal class PlainAuthenticationPlugin : Sha256AuthenticationPlugin
{
	private MySqlXConnectionStringBuilder _settings;

	public override string PluginName => "Plain Authentication Plugin";

	public string AuthName => "PLAIN";

	public PlainAuthenticationPlugin(MySqlXConnectionStringBuilder settings)
	{
		_settings = settings;
	}

	public byte[] GetAuthData()
	{
		return Encoding.UTF8.GetBytes($"{_settings.Database}\0{_settings.UserID}\0{_settings.Password}");
	}
}
