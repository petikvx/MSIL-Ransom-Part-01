namespace Gecko.WebIDL;

public class MozInterAppMessageEvent : WebIDLBase
{
	public object Data => GetProperty<object>("data");

	public MozInterAppMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
