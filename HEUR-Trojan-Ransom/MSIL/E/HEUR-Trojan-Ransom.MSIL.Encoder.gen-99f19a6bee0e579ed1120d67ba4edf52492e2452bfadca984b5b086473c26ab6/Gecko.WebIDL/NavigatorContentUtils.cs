namespace Gecko.WebIDL;

public class NavigatorContentUtils : WebIDLBase
{
	public NavigatorContentUtils(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void RegisterProtocolHandler(string scheme, string url, string title)
	{
		CallVoidMethod("registerProtocolHandler", scheme, url, title);
	}

	public void RegisterContentHandler(string mimeType, string url, string title)
	{
		CallVoidMethod("registerContentHandler", mimeType, url, title);
	}
}
