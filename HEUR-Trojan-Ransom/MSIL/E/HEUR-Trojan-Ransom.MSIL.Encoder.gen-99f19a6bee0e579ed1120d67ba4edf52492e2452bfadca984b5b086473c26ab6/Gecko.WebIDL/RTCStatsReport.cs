namespace Gecko.WebIDL;

public class RTCStatsReport : WebIDLBase
{
	public string MozPcid => GetProperty<string>("mozPcid");

	public RTCStatsReport(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object Get(string key)
	{
		return CallMethod<object>("get", new object[1] { key });
	}

	public bool Has(string key)
	{
		return CallMethod<bool>("has", new object[1] { key });
	}
}
