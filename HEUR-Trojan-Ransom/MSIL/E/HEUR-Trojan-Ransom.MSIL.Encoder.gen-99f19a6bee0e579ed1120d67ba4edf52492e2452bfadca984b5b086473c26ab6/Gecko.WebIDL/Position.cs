namespace Gecko.WebIDL;

public class Position : WebIDLBase
{
	public nsISupports Coords => GetProperty<nsISupports>("coords");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public Position(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
