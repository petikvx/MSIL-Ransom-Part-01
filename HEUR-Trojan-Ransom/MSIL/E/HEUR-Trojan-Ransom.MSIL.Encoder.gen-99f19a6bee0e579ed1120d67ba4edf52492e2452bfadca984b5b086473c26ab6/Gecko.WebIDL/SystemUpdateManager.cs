namespace Gecko.WebIDL;

public class SystemUpdateManager : WebIDLBase
{
	public SystemUpdateManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object[]> GetProviders()
	{
		return CallMethod<Promise<object[]>>("getProviders", new object[0]);
	}

	public Promise<nsISupports> SetActiveProvider(string uuid)
	{
		return CallMethod<Promise<nsISupports>>("setActiveProvider", new object[1] { uuid });
	}

	public Promise<nsISupports> GetActiveProvider()
	{
		return CallMethod<Promise<nsISupports>>("getActiveProvider", new object[0]);
	}
}
