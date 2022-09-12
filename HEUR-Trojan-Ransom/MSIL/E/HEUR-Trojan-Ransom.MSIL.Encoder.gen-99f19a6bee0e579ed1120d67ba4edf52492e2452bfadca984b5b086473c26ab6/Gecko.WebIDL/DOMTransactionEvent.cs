namespace Gecko.WebIDL;

public class DOMTransactionEvent : WebIDLBase
{
	public object Transactions => GetProperty<object>("transactions");

	public DOMTransactionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
