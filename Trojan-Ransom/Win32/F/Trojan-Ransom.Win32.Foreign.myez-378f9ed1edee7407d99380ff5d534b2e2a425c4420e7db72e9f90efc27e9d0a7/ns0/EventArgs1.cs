using System;
using System.Net;

namespace ns0;

internal sealed class EventArgs1 : EventArgs
{
	internal HttpWebRequest httpWebRequest_0;

	internal Exception exception_0;

	public HttpWebRequest HttpWebRequest_0 => httpWebRequest_0;

	public Exception Exception_0 => exception_0;

	internal EventArgs1(HttpWebRequest httpWebRequest_1, Exception exception_1)
	{
		httpWebRequest_0 = httpWebRequest_1;
		exception_0 = exception_1;
	}
}
