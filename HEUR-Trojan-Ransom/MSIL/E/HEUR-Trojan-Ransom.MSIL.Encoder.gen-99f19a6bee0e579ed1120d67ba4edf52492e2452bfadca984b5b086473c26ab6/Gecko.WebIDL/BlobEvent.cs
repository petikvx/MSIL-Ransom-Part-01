namespace Gecko.WebIDL;

public class BlobEvent : WebIDLBase
{
	public nsIDOMBlob Data => GetProperty<nsIDOMBlob>("data");

	public BlobEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
