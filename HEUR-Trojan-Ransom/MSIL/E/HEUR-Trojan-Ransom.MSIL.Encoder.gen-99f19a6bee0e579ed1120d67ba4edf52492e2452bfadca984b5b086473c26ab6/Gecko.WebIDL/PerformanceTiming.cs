namespace Gecko.WebIDL;

public class PerformanceTiming : WebIDLBase
{
	public ulong NavigationStart => GetProperty<ulong>("navigationStart");

	public ulong UnloadEventStart => GetProperty<ulong>("unloadEventStart");

	public ulong UnloadEventEnd => GetProperty<ulong>("unloadEventEnd");

	public ulong RedirectStart => GetProperty<ulong>("redirectStart");

	public ulong RedirectEnd => GetProperty<ulong>("redirectEnd");

	public ulong FetchStart => GetProperty<ulong>("fetchStart");

	public ulong DomainLookupStart => GetProperty<ulong>("domainLookupStart");

	public ulong DomainLookupEnd => GetProperty<ulong>("domainLookupEnd");

	public ulong ConnectStart => GetProperty<ulong>("connectStart");

	public ulong ConnectEnd => GetProperty<ulong>("connectEnd");

	public ulong RequestStart => GetProperty<ulong>("requestStart");

	public ulong ResponseStart => GetProperty<ulong>("responseStart");

	public ulong ResponseEnd => GetProperty<ulong>("responseEnd");

	public ulong DomLoading => GetProperty<ulong>("domLoading");

	public ulong DomInteractive => GetProperty<ulong>("domInteractive");

	public ulong DomContentLoadedEventStart => GetProperty<ulong>("domContentLoadedEventStart");

	public ulong DomContentLoadedEventEnd => GetProperty<ulong>("domContentLoadedEventEnd");

	public ulong DomComplete => GetProperty<ulong>("domComplete");

	public ulong LoadEventStart => GetProperty<ulong>("loadEventStart");

	public ulong LoadEventEnd => GetProperty<ulong>("loadEventEnd");

	public PerformanceTiming(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
