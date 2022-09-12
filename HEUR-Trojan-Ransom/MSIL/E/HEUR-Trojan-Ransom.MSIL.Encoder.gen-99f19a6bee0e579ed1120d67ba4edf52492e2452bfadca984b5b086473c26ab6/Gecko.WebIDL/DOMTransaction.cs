namespace Gecko.WebIDL;

public class DOMTransaction : WebIDLBase
{
	public string Label => GetProperty<string>("label");

	public DOMTransaction(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
