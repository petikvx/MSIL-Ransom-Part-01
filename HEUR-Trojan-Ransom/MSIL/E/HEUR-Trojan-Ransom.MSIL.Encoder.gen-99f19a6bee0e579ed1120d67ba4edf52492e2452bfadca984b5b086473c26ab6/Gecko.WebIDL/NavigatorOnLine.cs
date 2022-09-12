namespace Gecko.WebIDL;

public class NavigatorOnLine : WebIDLBase
{
	public bool OnLine => GetProperty<bool>("onLine");

	public NavigatorOnLine(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
