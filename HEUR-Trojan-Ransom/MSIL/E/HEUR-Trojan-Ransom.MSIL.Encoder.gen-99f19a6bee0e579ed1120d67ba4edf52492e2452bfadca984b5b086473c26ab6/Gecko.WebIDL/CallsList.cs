namespace Gecko.WebIDL;

public class CallsList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public CallsList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
