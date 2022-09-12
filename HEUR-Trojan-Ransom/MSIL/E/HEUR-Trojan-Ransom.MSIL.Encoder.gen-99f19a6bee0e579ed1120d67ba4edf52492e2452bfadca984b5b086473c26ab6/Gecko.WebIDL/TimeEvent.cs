namespace Gecko.WebIDL;

public class TimeEvent : WebIDLBase
{
	public int Detail => GetProperty<int>("detail");

	public nsIDOMWindow View => GetProperty<nsIDOMWindow>("view");

	public TimeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitTimeEvent(string aType, nsIDOMWindow aView, int aDetail)
	{
		CallVoidMethod("initTimeEvent", aType, aView, aDetail);
	}
}
