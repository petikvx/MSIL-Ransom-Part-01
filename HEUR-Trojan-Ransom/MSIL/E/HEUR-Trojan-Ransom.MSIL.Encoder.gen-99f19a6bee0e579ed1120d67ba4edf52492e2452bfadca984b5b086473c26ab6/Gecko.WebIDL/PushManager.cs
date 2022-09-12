namespace Gecko.WebIDL;

public class PushManager : WebIDLBase
{
	public PushManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetPushManagerImpl(nsISupports store)
	{
		CallVoidMethod("setPushManagerImpl", store);
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
}
