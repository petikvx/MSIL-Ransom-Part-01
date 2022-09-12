namespace Gecko.WebIDL;

public class RGBColor : WebIDLBase
{
	public nsISupports Red => GetProperty<nsISupports>("red");

	public nsISupports Green => GetProperty<nsISupports>("green");

	public nsISupports Blue => GetProperty<nsISupports>("blue");

	public nsISupports Alpha => GetProperty<nsISupports>("alpha");

	public RGBColor(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
