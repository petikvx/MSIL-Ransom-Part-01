namespace Gecko.WebIDL;

public class NavigatorID : WebIDLBase
{
	public string AppCodeName => GetProperty<string>("appCodeName");

	public string AppName => GetProperty<string>("appName");

	public string AppVersion => GetProperty<string>("appVersion");

	public string Platform => GetProperty<string>("platform");

	public string UserAgent => GetProperty<string>("userAgent");

	public string Product => GetProperty<string>("product");

	public NavigatorID(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool TaintEnabled()
	{
		return CallMethod<bool>("taintEnabled", new object[0]);
	}
}
