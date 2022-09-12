using Gecko.Interop;

namespace Gecko.Net;

public static class HttpActivityDistributor
{
	private static ComPtr<nsIHttpActivityDistributor> _httpActivityDistributor;

	public static bool IsActive => _httpActivityDistributor.Instance.GetIsActiveAttribute();

	static HttpActivityDistributor()
	{
		_httpActivityDistributor = Xpcom.GetService2<nsIHttpActivityDistributor>("@mozilla.org/network/http-activity-distributor;1");
	}

	public static void AddObserver(nsIHttpActivityObserver observer)
	{
		_httpActivityDistributor.Instance.AddObserver(observer);
	}

	public static void AddObserver(BaseHttpActivityObserver observer)
	{
		if (!observer._isRegistered)
		{
			_httpActivityDistributor.Instance.AddObserver(observer);
			observer._isRegistered = true;
		}
	}

	public static void RemoveObserver(BaseHttpActivityObserver observer)
	{
		if (observer._isRegistered)
		{
			_httpActivityDistributor.Instance.RemoveObserver(observer);
			observer._isRegistered = false;
		}
	}
}
