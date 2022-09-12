using System.Reflection;

namespace MySql.Data.MySqlClient.Authentication;

internal struct PluginInfo
{
	public string Type;

	public Assembly Assembly;

	public PluginInfo(string type)
	{
		Type = type;
		Assembly = null;
	}
}
