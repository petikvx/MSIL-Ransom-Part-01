using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Target;

public class WebBrowserWithProxy : WebBrowser
{
	private const int URLMON_OPTION_USERAGENT = 268435457;

	public string user_agent = "";

	public string user_referer = "";

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	public static void ChangeUserAgent(string Agent)
	{
		UrlMkSetSessionOption(268435457, Agent, Agent.Length, 0);
	}

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	public void Goto(string url)
	{
		Uri result = null;
		if (!Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out result))
		{
			throw new ArgumentException("The url is not valid. ");
		}
		if (user_agent.Length > 5)
		{
			ChangeUserAgent(user_agent);
		}
		((WebBrowser)this).Navigate(result);
	}

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	public void Goto1(string url)
	{
		Uri result = null;
		if (!Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out result))
		{
			throw new ArgumentException("The url is not valid. ");
		}
		if (user_agent.Length > 5)
		{
			ChangeUserAgent(user_agent);
		}
		((WebBrowser)this).Navigate(result);
	}

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	public void setuseragent()
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\5.0\\User Agent");
		registryKey.Flush();
		registryKey.SetValue("", "Mozilla/5.0");
		registryKey.SetValue("Compatible", "Windows");
		registryKey.SetValue("Version", "U");
		registryKey.SetValue("Platform", "Windows NT 5.1; en-US");
	}

	[DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
	private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
}
