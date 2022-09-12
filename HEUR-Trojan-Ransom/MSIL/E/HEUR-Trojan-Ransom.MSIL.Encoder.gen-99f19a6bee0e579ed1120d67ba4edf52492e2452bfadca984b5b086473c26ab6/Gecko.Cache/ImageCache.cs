using Gecko.Interop;

namespace Gecko.Cache;

public static class ImageCache
{
	private static ComPtr<imgICache> _imgCache;

	static ImageCache()
	{
		_imgCache = Xpcom.GetService2<imgICache>("@mozilla.org/image/cache;1");
	}

	public static void ClearCache(bool chrome)
	{
		_imgCache.Instance.ClearCache(chrome);
	}

	public static Properties FindEntryProperties(string url, GeckoDocument document)
	{
		nsIURI obj = IOService.CreateNsIUri(url);
		Properties result = _imgCache.Instance.FindEntryProperties(obj, document._domDocument).Wrap((nsIProperties x) => new Properties(x));
		Xpcom.FreeComObject(ref obj);
		return result;
	}
}
