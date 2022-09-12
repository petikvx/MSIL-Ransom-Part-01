namespace Gecko.WebIDL;

public class DOMStringList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public DOMStringList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool Contains(string @string)
	{
		return CallMethod<bool>("contains", new object[1] { @string });
	}
}
