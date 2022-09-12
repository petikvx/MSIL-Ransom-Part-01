namespace Gecko.WebIDL;

public class DOMQuad : WebIDLBase
{
	public nsISupports P1 => GetProperty<nsISupports>("p1");

	public nsISupports P2 => GetProperty<nsISupports>("p2");

	public nsISupports P3 => GetProperty<nsISupports>("p3");

	public nsISupports P4 => GetProperty<nsISupports>("p4");

	public nsISupports Bounds => GetProperty<nsISupports>("bounds");

	public DOMQuad(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
