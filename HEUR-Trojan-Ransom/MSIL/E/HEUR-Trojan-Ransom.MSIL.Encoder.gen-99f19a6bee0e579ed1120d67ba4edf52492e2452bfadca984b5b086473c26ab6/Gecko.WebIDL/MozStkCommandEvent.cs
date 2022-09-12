namespace Gecko.WebIDL;

public class MozStkCommandEvent : WebIDLBase
{
	public object Command => GetProperty<object>("command");

	public MozStkCommandEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
