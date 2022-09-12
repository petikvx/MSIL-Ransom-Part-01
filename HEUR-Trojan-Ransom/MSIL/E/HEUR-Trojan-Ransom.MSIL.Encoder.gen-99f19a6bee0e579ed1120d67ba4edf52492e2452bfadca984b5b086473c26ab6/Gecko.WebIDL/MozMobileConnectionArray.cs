namespace Gecko.WebIDL;

public class MozMobileConnectionArray : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public MozMobileConnectionArray(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
