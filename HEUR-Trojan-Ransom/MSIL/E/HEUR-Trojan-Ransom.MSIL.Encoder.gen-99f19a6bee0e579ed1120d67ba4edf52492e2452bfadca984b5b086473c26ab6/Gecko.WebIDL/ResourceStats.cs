namespace Gecko.WebIDL;

public class ResourceStats : WebIDLBase
{
	public ResourceType Type => GetProperty<ResourceType>("type");

	public string Component => GetProperty<string>("component");

	public SystemService ServiceType => GetProperty<SystemService>("serviceType");

	public string ManifestURL => GetProperty<string>("manifestURL");

	public nsISupports Start => GetProperty<nsISupports>("start");

	public nsISupports End => GetProperty<nsISupports>("end");

	public ResourceStats(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public WebIDLUnion<nsISupports, nsISupports> GetData()
	{
		return CallMethod<WebIDLUnion<nsISupports, nsISupports>>("getData", new object[0]);
	}
}
