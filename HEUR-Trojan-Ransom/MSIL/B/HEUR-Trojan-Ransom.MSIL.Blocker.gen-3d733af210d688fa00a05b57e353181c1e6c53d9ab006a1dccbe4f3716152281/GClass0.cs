using System;
using System.Net;

public class GClass0 : WebClient
{
	WebRequest WebClient.GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest)
		{
			GClass0.smethod_0((HttpWebRequest)webRequest, bool_0: false);
		}
		return webRequest;
	}

	static void smethod_0(HttpWebRequest httpWebRequest_0, bool bool_0)
	{
		httpWebRequest_0.KeepAlive = bool_0;
	}
}
