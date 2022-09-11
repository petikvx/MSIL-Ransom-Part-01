using System;
using System.Net;

namespace Extension;

public class WebClientWithTimeout : WebClient
{
	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		webRequest.Timeout = 5000;
		return webRequest;
	}
}
