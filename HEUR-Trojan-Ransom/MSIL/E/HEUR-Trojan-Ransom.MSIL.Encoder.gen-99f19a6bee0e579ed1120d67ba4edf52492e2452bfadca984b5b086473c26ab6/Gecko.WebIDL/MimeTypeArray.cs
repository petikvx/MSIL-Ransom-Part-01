namespace Gecko.WebIDL;

public class MimeTypeArray : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public MimeTypeArray(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
