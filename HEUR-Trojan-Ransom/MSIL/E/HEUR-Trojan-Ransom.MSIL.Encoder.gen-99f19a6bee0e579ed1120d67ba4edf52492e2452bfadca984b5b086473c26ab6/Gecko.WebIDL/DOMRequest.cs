namespace Gecko.WebIDL;

public class DOMRequest : WebIDLBase
{
	public DOMRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object Then()
	{
		return CallMethod<object>("then", new object[0]);
	}
}
