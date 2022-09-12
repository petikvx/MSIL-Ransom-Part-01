namespace Gecko.WebIDL;

public class RequestSyncTask : WebIDLBase
{
	public nsISupports App => GetProperty<nsISupports>("app");

	public RequestSyncTaskPolicyState State => GetProperty<RequestSyncTaskPolicyState>("state");

	public int OverwrittenMinInterval => GetProperty<int>("overwrittenMinInterval");

	public USVString Task => GetProperty<USVString>("task");

	public nsISupports LastSync => GetProperty<nsISupports>("lastSync");

	public USVString WakeUpPage => GetProperty<USVString>("wakeUpPage");

	public bool OneShot => GetProperty<bool>("oneShot");

	public int MinInterval => GetProperty<int>("minInterval");

	public bool WifiOnly => GetProperty<bool>("wifiOnly");

	public object Data => GetProperty<object>("data");

	public RequestSyncTask(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise SetPolicy(RequestSyncTaskPolicyState aState)
	{
		return CallMethod<Promise>("setPolicy", new object[1] { aState });
	}

	public Promise SetPolicy(RequestSyncTaskPolicyState aState, int ovewrittenMinInterval)
	{
		return CallMethod<Promise>("setPolicy", new object[2] { aState, ovewrittenMinInterval });
	}

	public Promise RunNow()
	{
		return CallMethod<Promise>("runNow", new object[0]);
	}
}
