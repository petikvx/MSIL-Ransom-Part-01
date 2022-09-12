namespace Gecko.WebIDL;

public class MediaStreamList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public MediaStreamList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
