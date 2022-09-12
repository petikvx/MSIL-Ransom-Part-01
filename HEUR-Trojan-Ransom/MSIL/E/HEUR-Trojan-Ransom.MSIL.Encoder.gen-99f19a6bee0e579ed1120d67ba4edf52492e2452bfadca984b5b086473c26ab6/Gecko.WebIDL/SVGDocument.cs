namespace Gecko.WebIDL;

public class SVGDocument : WebIDLBase
{
	public string Domain => GetProperty<string>("domain");

	public nsISupports RootElement => GetProperty<nsISupports>("rootElement");

	public SVGDocument(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
