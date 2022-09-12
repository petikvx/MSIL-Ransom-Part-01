namespace Gecko.WebIDL;

public class PermissionSettings : WebIDLBase
{
	public PermissionSettings(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string Get(string permission, string manifestURI, string origin, bool browserFlag)
	{
		return CallMethod<string>("get", new object[4] { permission, manifestURI, origin, browserFlag });
	}

	public void Set(string permission, string value, string manifestURI, string origin, bool browserFlag)
	{
		CallVoidMethod("set", permission, value, manifestURI, origin, browserFlag);
	}

	public bool IsExplicit(string permission, string manifestURI, string origin, bool browserFlag)
	{
		return CallMethod<bool>("isExplicit", new object[4] { permission, manifestURI, origin, browserFlag });
	}

	public void Remove(string permission, string manifestURI, string origin)
	{
		CallVoidMethod("remove", permission, manifestURI, origin);
	}
}
