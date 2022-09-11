using System;
using System.Net;

namespace stub;

public class WebClientEx : WebClient
{
	protected override WebRequest GetWebRequest(Uri address)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)base.GetWebRequest(address);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		return httpWebRequest;
	}
}
