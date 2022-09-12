namespace Gecko.WebIDL;

public class RecordErrorEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public RecordErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
