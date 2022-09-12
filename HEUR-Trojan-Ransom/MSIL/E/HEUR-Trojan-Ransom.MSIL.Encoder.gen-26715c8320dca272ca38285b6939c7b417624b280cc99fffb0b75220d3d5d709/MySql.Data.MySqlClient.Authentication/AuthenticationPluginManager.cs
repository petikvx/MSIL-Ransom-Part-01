using System;
using System.Collections.Generic;

namespace MySql.Data.MySqlClient.Authentication;

internal class AuthenticationPluginManager
{
	private static readonly Dictionary<string, PluginInfo> Plugins;

	private static void AuthenticationManagerCtorConfiguration()
	{
		Plugins["authentication_windows_client"] = new PluginInfo("MySql.Data.MySqlClient.Authentication.MySqlWindowsAuthenticationPlugin");
		if (MySqlConfiguration.Settings == null || MySqlConfiguration.Settings.AuthenticationPlugins == null)
		{
			return;
		}
		foreach (AuthenticationPluginConfigurationElement authenticationPlugin in MySqlConfiguration.Settings.AuthenticationPlugins)
		{
			Plugins[authenticationPlugin.Name] = new PluginInfo(authenticationPlugin.Type);
		}
	}

	static AuthenticationPluginManager()
	{
		Plugins = new Dictionary<string, PluginInfo>();
		Plugins["mysql_native_password"] = new PluginInfo("MySql.Data.MySqlClient.Authentication.MySqlNativePasswordPlugin");
		Plugins["sha256_password"] = new PluginInfo("MySql.Data.MySqlClient.Authentication.Sha256AuthenticationPlugin");
		Plugins["authentication_windows_client"] = new PluginInfo("MySql.Data.MySqlClient.Authentication.MySqlWindowsAuthenticationPlugin");
		Plugins["caching_sha2_password"] = new PluginInfo("MySql.Data.MySqlClient.Authentication.CachingSha2AuthenticationPlugin");
		AuthenticationManagerCtorConfiguration();
	}

	public static MySqlAuthenticationPlugin GetPlugin(string method)
	{
		if (!Plugins.ContainsKey(method))
		{
			throw new MySqlException(string.Format(Resources.AuthenticationMethodNotSupported, method));
		}
		return CreatePlugin(method);
	}

	private static MySqlAuthenticationPlugin CreatePlugin(string method)
	{
		PluginInfo pluginInfo = Plugins[method];
		try
		{
			return (MySqlAuthenticationPlugin)Activator.CreateInstance(Type.GetType(pluginInfo.Type));
		}
		catch (Exception ex)
		{
			throw new MySqlException(string.Format(Resources.UnableToCreateAuthPlugin, method), ex);
		}
	}
}
