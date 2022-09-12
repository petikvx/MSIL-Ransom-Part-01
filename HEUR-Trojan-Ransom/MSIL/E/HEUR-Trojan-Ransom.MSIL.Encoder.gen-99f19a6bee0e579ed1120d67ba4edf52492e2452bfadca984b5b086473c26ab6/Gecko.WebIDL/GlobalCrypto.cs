namespace Gecko.WebIDL;

public class GlobalCrypto : WebIDLBase
{
	public nsISupports Crypto => GetProperty<nsISupports>("crypto");

	public GlobalCrypto(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
