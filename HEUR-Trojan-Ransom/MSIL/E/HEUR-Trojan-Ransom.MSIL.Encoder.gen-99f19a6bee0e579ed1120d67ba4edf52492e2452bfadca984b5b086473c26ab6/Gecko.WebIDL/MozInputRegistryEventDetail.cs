namespace Gecko.WebIDL;

public class MozInputRegistryEventDetail : WebIDLBase
{
	public string ManifestURL => GetProperty<string>("manifestURL");

	public string InputId => GetProperty<string>("inputId");

	public object InputManifest => GetProperty<object>("inputManifest");

	public MozInputRegistryEventDetail(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void WaitUntil(Promise<object> p)
	{
		CallVoidMethod("waitUntil", p);
	}
}
