namespace Gecko.WebIDL;

public class WindowClient : WebIDLBase
{
	public VisibilityState VisibilityState => GetProperty<VisibilityState>("visibilityState");

	public bool Focused => GetProperty<bool>("focused");

	public WindowClient(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Focus()
	{
		return CallMethod<Promise<nsISupports>>("focus", new object[0]);
	}
}
