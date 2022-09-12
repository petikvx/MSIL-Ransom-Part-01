namespace Gecko.WebIDL;

public class PaintRequestList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public PaintRequestList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
