using System;

namespace Gecko.WebIDL;

public class MediaKeySession : WebIDLBase
{
	public nsISupports Error => GetProperty<nsISupports>("error");

	public string KeySystem => GetProperty<string>("keySystem");

	public string SessionId => GetProperty<string>("sessionId");

	public double Expiration => GetProperty<double>("expiration");

	public Promise Closed => GetProperty<Promise>("closed");

	public nsISupports KeyStatuses => GetProperty<nsISupports>("keyStatuses");

	public MediaKeySession(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise GenerateRequest(string initDataType, IntPtr initData)
	{
		return CallMethod<Promise>("generateRequest", new object[2] { initDataType, initData });
	}

	public Promise<bool> Load(string sessionId)
	{
		return CallMethod<Promise<bool>>("load", new object[1] { sessionId });
	}

	public Promise Update(IntPtr response)
	{
		return CallMethod<Promise>("update", new object[1] { response });
	}

	public Promise Close()
	{
		return CallMethod<Promise>("close", new object[0]);
	}

	public Promise Remove()
	{
		return CallMethod<Promise>("remove", new object[0]);
	}
}
