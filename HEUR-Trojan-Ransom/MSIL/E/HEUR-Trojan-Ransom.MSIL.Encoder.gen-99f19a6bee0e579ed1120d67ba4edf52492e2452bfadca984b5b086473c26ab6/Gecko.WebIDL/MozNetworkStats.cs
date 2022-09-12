namespace Gecko.WebIDL;

public class MozNetworkStats : WebIDLBase
{
	public string AppManifestURL => GetProperty<string>("appManifestURL");

	public bool BrowsingTrafficOnly => GetProperty<bool>("browsingTrafficOnly");

	public string ServiceType => GetProperty<string>("serviceType");

	public nsISupports Network => GetProperty<nsISupports>("network");

	public nsISupports[] Data => GetProperty<nsISupports[]>("data");

	public object Start => GetProperty<object>("start");

	public object End => GetProperty<object>("end");

	public MozNetworkStats(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
