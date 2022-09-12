namespace Gecko.WebIDL;

public class CloseEvent : WebIDLBase
{
	public bool WasClean => GetProperty<bool>("wasClean");

	public ushort Code => GetProperty<ushort>("code");

	public string Reason => GetProperty<string>("reason");

	public CloseEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
