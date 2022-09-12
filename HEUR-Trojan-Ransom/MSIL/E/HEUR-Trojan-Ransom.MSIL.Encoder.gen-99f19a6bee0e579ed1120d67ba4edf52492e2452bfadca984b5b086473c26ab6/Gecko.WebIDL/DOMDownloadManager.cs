namespace Gecko.WebIDL;

public class DOMDownloadManager : WebIDLBase
{
	public DOMDownloadManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetDownloads()
	{
		return CallMethod<Promise<nsISupports[]>>("getDownloads", new object[0]);
	}

	public Promise<nsISupports> Remove(nsISupports download)
	{
		return CallMethod<Promise<nsISupports>>("remove", new object[1] { download });
	}

	public void ClearAllDone()
	{
		CallVoidMethod("clearAllDone");
	}

	public Promise<nsISupports> AdoptDownload()
	{
		return CallMethod<Promise<nsISupports>>("adoptDownload", new object[0]);
	}

	public Promise<nsISupports> AdoptDownload(object download)
	{
		return CallMethod<Promise<nsISupports>>("adoptDownload", new object[1] { download });
	}
}
