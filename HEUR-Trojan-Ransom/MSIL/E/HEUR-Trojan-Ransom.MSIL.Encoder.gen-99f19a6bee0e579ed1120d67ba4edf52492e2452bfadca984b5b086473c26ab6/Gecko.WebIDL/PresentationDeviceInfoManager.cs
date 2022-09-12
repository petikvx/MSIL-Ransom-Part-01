namespace Gecko.WebIDL;

public class PresentationDeviceInfoManager : WebIDLBase
{
	public PresentationDeviceInfoManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object[]> GetAll()
	{
		return CallMethod<Promise<object[]>>("getAll", new object[0]);
	}

	public void ForceDiscovery()
	{
		CallVoidMethod("forceDiscovery");
	}
}
