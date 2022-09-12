namespace Gecko.WebIDL;

public class MediaKeyError : WebIDLBase
{
	public uint SystemCode => GetProperty<uint>("systemCode");

	public MediaKeyError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
