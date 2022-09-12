namespace Gecko.WebIDL;

public class CompositionEvent : WebIDLBase
{
	public string Data => GetProperty<string>("data");

	public string Locale => GetProperty<string>("locale");

	public CompositionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, string dataArg, string localeArg)
	{
		CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg, viewArg, dataArg, localeArg);
	}
}
