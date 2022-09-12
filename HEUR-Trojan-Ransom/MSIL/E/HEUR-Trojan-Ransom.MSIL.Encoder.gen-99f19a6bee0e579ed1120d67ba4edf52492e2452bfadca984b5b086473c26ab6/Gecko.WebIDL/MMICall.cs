namespace Gecko.WebIDL;

public class MMICall : WebIDLBase
{
	public Promise<object> Result => GetProperty<Promise<object>>("result");

	public MMICall(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
