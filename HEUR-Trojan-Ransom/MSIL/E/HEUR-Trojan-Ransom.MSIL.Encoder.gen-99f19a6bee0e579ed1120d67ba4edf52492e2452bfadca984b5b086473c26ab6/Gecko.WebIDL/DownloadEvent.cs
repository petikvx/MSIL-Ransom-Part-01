namespace Gecko.WebIDL;

public class DownloadEvent : WebIDLBase
{
	public nsISupports Download => GetProperty<nsISupports>("download");

	public DownloadEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
