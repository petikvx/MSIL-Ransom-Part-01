namespace Gecko.WebIDL;

public class RequestSyncApp : WebIDLBase
{
	public USVString Origin => GetProperty<USVString>("origin");

	public USVString ManifestURL => GetProperty<USVString>("manifestURL");

	public bool IsInBrowserElement => GetProperty<bool>("isInBrowserElement");

	public RequestSyncApp(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
