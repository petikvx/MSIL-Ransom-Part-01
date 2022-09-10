using System;
using System.IO;
using CommandRegistration;
using HSPS.eServices.DigitalHighway.Logging;

namespace AvailableCommandsUpdater;

internal class Program
{
	private static int Main(string[] args)
	{
		string text = string.Empty;
		try
		{
			if (args.Length == 0)
			{
				throw new Exception("Missing file path to Command Registration Information Settings File.");
			}
			string text2 = args[0];
			string isUninstall = string.Empty;
			try
			{
				isUninstall = args[1];
			}
			catch (Exception)
			{
			}
			if (!File.Exists(text2))
			{
				throw new Exception("Invalid file path to Command Registration Information Settings File.");
			}
			RegisterAvailableCommands registerAvailableCommands = new RegisterAvailableCommands();
			text = registerAvailableCommands.RegisterCommands(text2, isUninstall);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
			Logger.Error((object)"Error encountered in main method of Command Registration executable.", ex);
		}
		if (text == "Commands Registered")
		{
			return 0;
		}
		return -1;
	}
}
