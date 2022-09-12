namespace Gecko.WebIDL;

public class DOMRectList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public DOMRectList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
