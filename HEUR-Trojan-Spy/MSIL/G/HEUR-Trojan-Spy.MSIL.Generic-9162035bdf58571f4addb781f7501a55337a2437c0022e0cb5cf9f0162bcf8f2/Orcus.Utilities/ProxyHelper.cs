using Microsoft.Win32;

namespace Orcus.Utilities;

public class ProxyHelper
{
	public static bool GetSystemProxy(out string ipAddress, out int port)
	{
		ipAddress = null;
		port = 0;
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
		if ((int)registryKey.GetValue("ProxyEnable", 0) != 1)
		{
			return false;
		}
		string text = (string)registryKey.GetValue("ProxyServer", "");
		if (!string.IsNullOrEmpty(text) && !text.StartsWith("http"))
		{
			string[] array = text.Split(new char[1] { ':' }, 2);
			ipAddress = array[0];
			port = int.Parse(array[1]);
			return true;
		}
		return false;
	}
}
