namespace Gecko.WebIDL;

public class SEResponse : WebIDLBase
{
	public nsISupports Channel => GetProperty<nsISupports>("channel");

	public byte Sw1 => GetProperty<byte>("sw1");

	public byte Sw2 => GetProperty<byte>("sw2");

	public byte[] Data => GetProperty<byte[]>("data");

	public SEResponse(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
