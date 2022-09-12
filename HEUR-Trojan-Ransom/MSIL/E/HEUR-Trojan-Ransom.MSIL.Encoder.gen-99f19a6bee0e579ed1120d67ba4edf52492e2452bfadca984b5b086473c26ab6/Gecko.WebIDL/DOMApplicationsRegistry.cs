namespace Gecko.WebIDL;

public class DOMApplicationsRegistry : WebIDLBase
{
	public nsISupports Mgmt => GetProperty<nsISupports>("mgmt");

	public DOMApplicationsRegistry(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Install(string url)
	{
		return CallMethod<nsISupports>("install", new object[1] { url });
	}

	public nsISupports Install(string url, object @params)
	{
		return CallMethod<nsISupports>("install", new object[2] { url, @params });
	}

	public nsISupports InstallPackage(string url)
	{
		return CallMethod<nsISupports>("installPackage", new object[1] { url });
	}

	public nsISupports InstallPackage(string url, object @params)
	{
		return CallMethod<nsISupports>("installPackage", new object[2] { url, @params });
	}

	public nsISupports GetSelf()
	{
		return CallMethod<nsISupports>("getSelf", new object[0]);
	}

	public nsISupports GetInstalled()
	{
		return CallMethod<nsISupports>("getInstalled", new object[0]);
	}

	public nsISupports CheckInstalled(string manifestUrl)
	{
		return CallMethod<nsISupports>("checkInstalled", new object[1] { manifestUrl });
	}

	public Promise<MozMap<object[]>> GetAdditionalLanguages()
	{
		return CallMethod<Promise<MozMap<object[]>>>("getAdditionalLanguages", new object[0]);
	}

	public Promise<object> GetLocalizationResource(string language, string version, string path, LocaleResourceType dataType)
	{
		return CallMethod<Promise<object>>("getLocalizationResource", new object[4] { language, version, path, dataType });
	}
}
