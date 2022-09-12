namespace Gecko.WebIDL;

public class Rect : WebIDLBase
{
	public nsISupports Top => GetProperty<nsISupports>("top");

	public nsISupports Right => GetProperty<nsISupports>("right");

	public nsISupports Bottom => GetProperty<nsISupports>("bottom");

	public nsISupports Left => GetProperty<nsISupports>("left");

	public Rect(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
