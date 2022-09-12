namespace Gecko.WebIDL;

public class IDBFileRequest : WebIDLBase
{
	public nsISupports FileHandle => GetProperty<nsISupports>("fileHandle");

	public nsISupports LockedFile => GetProperty<nsISupports>("lockedFile");

	public IDBFileRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
