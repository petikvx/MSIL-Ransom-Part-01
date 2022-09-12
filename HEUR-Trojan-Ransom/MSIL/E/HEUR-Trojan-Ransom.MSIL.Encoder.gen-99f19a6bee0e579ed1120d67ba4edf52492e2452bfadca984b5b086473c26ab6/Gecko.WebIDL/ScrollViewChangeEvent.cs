namespace Gecko.WebIDL;

public class ScrollViewChangeEvent : WebIDLBase
{
	public ScrollState State => GetProperty<ScrollState>("state");

	public ScrollViewChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
