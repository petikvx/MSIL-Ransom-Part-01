namespace Gecko.WebIDL;

public class PageTransitionEvent : WebIDLBase
{
	public bool Persisted => GetProperty<bool>("persisted");

	public PageTransitionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
