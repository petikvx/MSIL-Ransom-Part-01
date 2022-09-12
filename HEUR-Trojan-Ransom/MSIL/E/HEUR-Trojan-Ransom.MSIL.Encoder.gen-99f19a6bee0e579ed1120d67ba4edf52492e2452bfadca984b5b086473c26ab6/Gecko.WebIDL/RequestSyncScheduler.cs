namespace Gecko.WebIDL;

public class RequestSyncScheduler : WebIDLBase
{
	public RequestSyncScheduler(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Register(USVString task)
	{
		return CallMethod<Promise>("register", new object[1] { task });
	}

	public Promise Register(USVString task, object @params)
	{
		return CallMethod<Promise>("register", new object[2] { task, @params });
	}

	public Promise Unregister(USVString task)
	{
		return CallMethod<Promise>("unregister", new object[1] { task });
	}

	public Promise<object[]> Registrations()
	{
		return CallMethod<Promise<object[]>>("registrations", new object[0]);
	}

	public Promise<object> Registration(USVString task)
	{
		return CallMethod<Promise<object>>("registration", new object[1] { task });
	}
}
