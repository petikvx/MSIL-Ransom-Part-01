namespace Gecko.WebIDL;

public class InstallTriggerImpl : WebIDLBase
{
	public InstallTriggerImpl(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool Enabled()
	{
		return CallMethod<bool>("enabled", new object[0]);
	}

	public bool UpdateEnabled()
	{
		return CallMethod<bool>("updateEnabled", new object[0]);
	}

	public bool Install(MozMap<WebIDLUnion<string, object>> installs)
	{
		return CallMethod<bool>("install", new object[1] { installs });
	}

	public bool InstallChrome(ushort type, string url, string skin)
	{
		return CallMethod<bool>("installChrome", new object[3] { type, url, skin });
	}

	public bool StartSoftwareUpdate(string url)
	{
		return CallMethod<bool>("startSoftwareUpdate", new object[1] { url });
	}

	public bool StartSoftwareUpdate(string url, ushort flags)
	{
		return CallMethod<bool>("startSoftwareUpdate", new object[2] { url, flags });
	}
}
