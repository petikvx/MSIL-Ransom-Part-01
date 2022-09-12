using System.Collections.Generic;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko;

public static class CookieManager
{
	private static ComPtr<nsICookieManager2> _cookieManager;

	static CookieManager()
	{
		_cookieManager = Xpcom.GetService2<nsICookieManager2>("@mozilla.org/cookiemanager;1");
	}

	public static void Add(string host, string path, string name, string value, bool isSecure, bool isHttpOnly, bool isSession, long expiry)
	{
		_cookieManager.Instance.Add(new nsAUTF8String(host), new nsAUTF8String(path), new nsACString(name), new nsACString(value), isSecure, isHttpOnly, isSession, expiry);
	}

	public static bool CookieExists(Cookie cookie)
	{
		return _cookieManager.Instance.CookieExists(cookie._cookie);
	}

	public static int CountCookiesFromHost(string host)
	{
		return (int)_cookieManager.Instance.CountCookiesFromHost(new nsAUTF8String(host));
	}

	public static IEnumerator<Cookie> GetCookiesFromHost(string host)
	{
		return new GeckoEnumerator<Cookie, nsICookie2>(_cookieManager.Instance.GetCookiesFromHost(new nsAUTF8String(host)), (nsICookie2 x) => new Cookie(x));
	}

	public static IEnumerator<Cookie> GetEnumerator()
	{
		return new GeckoEnumerator<Cookie, nsICookie2>(_cookieManager.Instance.GetEnumeratorAttribute(), (nsICookie2 x) => new Cookie(x));
	}

	public static void ImportCookies(string filename)
	{
		_cookieManager.Instance.ImportCookies((nsIFile)Xpcom.NewNativeLocalFile(filename));
	}

	public static void Remove(string host, string name, string path, bool blocked)
	{
		_cookieManager.Instance.Remove(new nsAUTF8String(host), new nsACString(name), new nsAUTF8String(path), blocked);
	}

	public static void RemoveAll()
	{
		_cookieManager.Instance.RemoveAll();
	}
}
