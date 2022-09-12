namespace Gecko.WebIDL;

public class CustomEvent : WebIDLBase
{
	public object Detail => GetProperty<object>("detail");

	public CustomEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitCustomEvent(string type, bool canBubble, bool cancelable, object detail)
	{
		CallVoidMethod("initCustomEvent", type, canBubble, cancelable, detail);
	}
}
