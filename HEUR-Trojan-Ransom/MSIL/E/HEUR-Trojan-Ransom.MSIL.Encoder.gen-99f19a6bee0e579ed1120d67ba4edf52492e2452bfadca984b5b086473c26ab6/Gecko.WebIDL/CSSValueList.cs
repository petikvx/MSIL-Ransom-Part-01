namespace Gecko.WebIDL;

public class CSSValueList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public CSSValueList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
