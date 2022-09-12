namespace Gecko.WebIDL;

public class MessagePortList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public MessagePortList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
