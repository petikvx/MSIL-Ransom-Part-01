namespace Gecko.WebIDL;

public class PerformanceNavigation : WebIDLBase
{
	public ushort Type => GetProperty<ushort>("type");

	public ushort RedirectCount => GetProperty<ushort>("redirectCount");

	public PerformanceNavigation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
