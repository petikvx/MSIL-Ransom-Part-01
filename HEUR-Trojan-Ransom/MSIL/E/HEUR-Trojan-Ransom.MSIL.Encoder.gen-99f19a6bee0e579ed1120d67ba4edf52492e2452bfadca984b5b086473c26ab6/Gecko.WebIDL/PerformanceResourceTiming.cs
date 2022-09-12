namespace Gecko.WebIDL;

public class PerformanceResourceTiming : WebIDLBase
{
	public string InitiatorType => GetProperty<string>("initiatorType");

	public string NextHopProtocol => GetProperty<string>("nextHopProtocol");

	public double RedirectStart => GetProperty<double>("redirectStart");

	public double RedirectEnd => GetProperty<double>("redirectEnd");

	public double FetchStart => GetProperty<double>("fetchStart");

	public double DomainLookupStart => GetProperty<double>("domainLookupStart");

	public double DomainLookupEnd => GetProperty<double>("domainLookupEnd");

	public double ConnectStart => GetProperty<double>("connectStart");

	public double ConnectEnd => GetProperty<double>("connectEnd");

	public double SecureConnectionStart => GetProperty<double>("secureConnectionStart");

	public double RequestStart => GetProperty<double>("requestStart");

	public double ResponseStart => GetProperty<double>("responseStart");

	public double ResponseEnd => GetProperty<double>("responseEnd");

	public ulong TransferSize => GetProperty<ulong>("transferSize");

	public ulong EncodedBodySize => GetProperty<ulong>("encodedBodySize");

	public ulong DecodedBodySize => GetProperty<ulong>("decodedBodySize");

	public PerformanceResourceTiming(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
