using Gecko.Interop;
using Gecko.Observers;

namespace Gecko;

public static class ObserverService
{
	private static ComPtr<nsIObserverService> _observerService;

	static ObserverService()
	{
		_observerService = Xpcom.GetService2<nsIObserverService>("@mozilla.org/observer-service;1");
	}

	public static void AddObserver(nsIObserver observer, string topic, bool ownsWeak)
	{
		_observerService.Instance.AddObserver(observer, topic, ownsWeak);
	}

	public static void RemoveObserver(nsIObserver observer, string topic)
	{
		_observerService.Instance.RemoveObserver(observer, topic);
	}

	public static void AddObserver(BaseHttpModifyRequestObserver observer)
	{
		if (!observer._isRegistered)
		{
			_observerService.Instance.AddObserver(observer, "http-on-modify-request", ownsWeak: false);
		}
	}

	public static void RemoveObserver(BaseHttpModifyRequestObserver observer)
	{
		if (observer._isRegistered)
		{
			_observerService.Instance.RemoveObserver(observer, "http-on-modify-request");
		}
	}

	public static void AddObserver(BaseHttpRequestResponseObserver observer)
	{
		if (!observer._isRegistered)
		{
			_observerService.Instance.AddObserver(observer, "http-on-modify-request", ownsWeak: false);
			_observerService.Instance.AddObserver(observer, "http-on-examine-response", ownsWeak: false);
		}
	}

	public static void RemoveObserver(BaseHttpRequestResponseObserver observer)
	{
		if (observer._isRegistered)
		{
			_observerService.Instance.RemoveObserver(observer, "http-on-modify-request");
			_observerService.Instance.RemoveObserver(observer, "http-on-examine-response");
		}
	}
}
