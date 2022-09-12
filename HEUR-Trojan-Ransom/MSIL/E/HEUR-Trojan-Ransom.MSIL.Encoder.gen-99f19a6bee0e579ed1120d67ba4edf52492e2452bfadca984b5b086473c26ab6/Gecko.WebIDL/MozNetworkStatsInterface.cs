namespace Gecko.WebIDL;

public class MozNetworkStatsInterface : WebIDLBase
{
	public int Type => GetProperty<int>("type");

	public string Id => GetProperty<string>("id");

	public MozNetworkStatsInterface(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
