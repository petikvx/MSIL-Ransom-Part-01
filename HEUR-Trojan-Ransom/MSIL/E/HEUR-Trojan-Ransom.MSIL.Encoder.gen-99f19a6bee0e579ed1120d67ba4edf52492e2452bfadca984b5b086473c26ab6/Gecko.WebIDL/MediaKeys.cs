using System;

namespace Gecko.WebIDL;

public class MediaKeys : WebIDLBase
{
	public string KeySystem => GetProperty<string>("keySystem");

	public MediaKeys(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateSession()
	{
		return CallMethod<nsISupports>("createSession", new object[0]);
	}

	public nsISupports CreateSession(SessionType sessionType)
	{
		return CallMethod<nsISupports>("createSession", new object[1] { sessionType });
	}

	public Promise SetServerCertificate(WebIDLUnion<IntPtr, IntPtr> serverCertificate)
	{
		return CallMethod<Promise>("setServerCertificate", new object[1] { serverCertificate });
	}
}
