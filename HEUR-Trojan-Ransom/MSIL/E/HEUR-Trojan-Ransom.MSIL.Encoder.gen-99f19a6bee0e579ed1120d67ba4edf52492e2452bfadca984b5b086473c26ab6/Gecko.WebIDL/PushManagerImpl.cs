namespace Gecko.WebIDL;

public class PushManagerImpl : WebIDLBase
{
	public PushManagerImpl(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Subscribe()
	{
		return CallMethod<Promise<nsISupports>>("subscribe", new object[0]);
	}

	public Promise<nsISupports> GetSubscription()
	{
		return CallMethod<Promise<nsISupports>>("getSubscription", new object[0]);
	}

	public Promise<PushPermissionState> PermissionState()
	{
		return CallMethod<Promise<PushPermissionState>>("permissionState", new object[0]);
	}

	public void SetScope(string scope)
	{
		CallVoidMethod("setScope", scope);
	}
}
