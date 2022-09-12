namespace Gecko.WebIDL;

public class MediaError : WebIDLBase
{
	public ushort Code => GetProperty<ushort>("code");

	public MediaError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
