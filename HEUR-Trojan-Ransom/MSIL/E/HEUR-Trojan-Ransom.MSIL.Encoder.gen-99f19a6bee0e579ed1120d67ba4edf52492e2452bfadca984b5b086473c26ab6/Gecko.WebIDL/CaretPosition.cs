namespace Gecko.WebIDL;

public class CaretPosition : WebIDLBase
{
	public nsIDOMNode OffsetNode => GetProperty<nsIDOMNode>("offsetNode");

	public uint Offset => GetProperty<uint>("offset");

	public CaretPosition(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetClientRect()
	{
		return CallMethod<nsISupports>("getClientRect", new object[0]);
	}
}
