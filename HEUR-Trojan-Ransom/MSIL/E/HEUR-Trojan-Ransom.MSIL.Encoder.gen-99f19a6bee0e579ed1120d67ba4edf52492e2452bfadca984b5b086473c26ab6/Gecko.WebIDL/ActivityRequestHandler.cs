namespace Gecko.WebIDL;

public class ActivityRequestHandler : WebIDLBase
{
	public object Source => GetProperty<object>("source");

	public ActivityRequestHandler(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PostResult(object result)
	{
		CallVoidMethod("postResult", result);
	}

	public void PostError(string error)
	{
		CallVoidMethod("postError", error);
	}
}
