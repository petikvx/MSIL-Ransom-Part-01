using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko;

public static class IOService
{
	private static ComPtr<nsIIOService2> _service;

	public static bool Offline
	{
		get
		{
			return _service.Instance.GetOfflineAttribute();
		}
		set
		{
			_service.Instance.SetOfflineAttribute(value);
		}
	}

	public static bool ManageOfflineStatus
	{
		get
		{
			return _service.Instance.GetManageOfflineStatusAttribute();
		}
		set
		{
			_service.Instance.SetManageOfflineStatusAttribute(value);
		}
	}

	static IOService()
	{
		_service = Xpcom.GetService2<nsIIOService2>("@mozilla.org/network/io-service;1");
	}

	public static nsIURI CreateNsIUri(string url)
	{
		using nsAUTF8String aSpec = new nsAUTF8String(url);
		return _service.Instance.NewURI(aSpec, null, null);
	}

	internal static nsIURL CreateNsIUrl(string url)
	{
		nsIURI nsIURI2 = CreateNsIUri(url);
		nsIURL result = Xpcom.QueryInterface<nsIURL>(nsIURI2);
		Marshal.ReleaseComObject(nsIURI2);
		return result;
	}

	public static nsIChannel NewChannelFromUri(nsIURI uri)
	{
		return _service.Instance.NewChannelFromURI(uri);
	}

	public static nsIChannel NewChannelFromUriWithProxyFlags(nsIURI uri, nsIURI proxyUri, uint proxyFlags)
	{
		return _service.Instance.NewChannelFromURIWithProxyFlags(uri, proxyUri, proxyFlags);
	}
}
