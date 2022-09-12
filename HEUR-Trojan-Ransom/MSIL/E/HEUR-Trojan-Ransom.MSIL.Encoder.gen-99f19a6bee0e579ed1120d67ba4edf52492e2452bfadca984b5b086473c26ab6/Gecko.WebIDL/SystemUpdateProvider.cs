namespace Gecko.WebIDL;

public class SystemUpdateProvider : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Uuid => GetProperty<string>("uuid");

	public SystemUpdateProvider(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void CheckForUpdate()
	{
		CallVoidMethod("checkForUpdate");
	}

	public void StartDownload()
	{
		CallVoidMethod("startDownload");
	}

	public void StopDownload()
	{
		CallVoidMethod("stopDownload");
	}

	public void ApplyUpdate()
	{
		CallVoidMethod("applyUpdate");
	}

	public bool SetParameter(string name, string value)
	{
		return CallMethod<bool>("setParameter", new object[2] { name, value });
	}

	public string GetParameter(string name)
	{
		return CallMethod<string>("getParameter", new object[1] { name });
	}
}
