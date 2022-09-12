namespace Gecko.WebIDL;

public class HashChangeEvent : WebIDLBase
{
	public string OldURL => GetProperty<string>("oldURL");

	public string NewURL => GetProperty<string>("newURL");

	public HashChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitHashChangeEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string oldURLArg, string newURLArg)
	{
		CallVoidMethod("initHashChangeEvent", typeArg, canBubbleArg, cancelableArg, oldURLArg, newURLArg);
	}
}
