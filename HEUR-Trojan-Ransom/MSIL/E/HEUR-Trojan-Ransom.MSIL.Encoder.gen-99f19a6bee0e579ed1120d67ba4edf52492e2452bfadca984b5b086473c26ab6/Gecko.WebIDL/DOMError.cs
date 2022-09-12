namespace Gecko.WebIDL;

public class DOMError : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Message => GetProperty<string>("message");

	public DOMError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
