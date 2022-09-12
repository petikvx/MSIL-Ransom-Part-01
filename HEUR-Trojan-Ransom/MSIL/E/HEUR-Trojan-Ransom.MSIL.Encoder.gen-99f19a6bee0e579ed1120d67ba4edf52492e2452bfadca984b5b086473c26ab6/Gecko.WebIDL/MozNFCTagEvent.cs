namespace Gecko.WebIDL;

public class MozNFCTagEvent : WebIDLBase
{
	public nsISupports Tag => GetProperty<nsISupports>("tag");

	public nsISupports[] NdefRecords => GetProperty<nsISupports[]>("ndefRecords");

	public MozNFCTagEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
