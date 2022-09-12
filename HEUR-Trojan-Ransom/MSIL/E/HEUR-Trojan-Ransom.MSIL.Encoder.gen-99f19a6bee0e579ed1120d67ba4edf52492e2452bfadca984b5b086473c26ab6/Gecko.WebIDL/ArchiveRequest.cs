namespace Gecko.WebIDL;

public class ArchiveRequest : WebIDLBase
{
	public nsISupports Reader => GetProperty<nsISupports>("reader");

	public ArchiveRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
