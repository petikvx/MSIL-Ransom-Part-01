namespace Gecko.WebIDL;

public class _Promise : WebIDLBase
{
	public _Promise(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object Then()
	{
		return CallMethod<object>("then", new object[0]);
	}

	public object Catch()
	{
		return CallMethod<object>("catch", new object[0]);
	}
}
