using System;
using System.Collections.Generic;
using System.ComponentModel;
using Gecko.Net;

namespace Gecko;

public class GeckoObserveHttpModifyRequestEventArgs : CancelEventArgs
{
	public readonly Uri Uri;

	public readonly Uri Referrer;

	public readonly string RequestMethod;

	public readonly byte[] RequestBody;

	public readonly List<KeyValuePair<string, string>> RequestHeaders;

	public readonly HttpChannel Channel;

	public readonly bool? ReqBodyContainsHeaders;

	public GeckoObserveHttpModifyRequestEventArgs(Uri uri, Uri refVal, string reqMethod, byte[] reqBody, List<KeyValuePair<string, string>> reqHeaders, HttpChannel httpChan, bool? bodyContainsHeaders)
		: base(cancel: false)
	{
		Uri = uri;
		Referrer = refVal;
		RequestMethod = reqMethod;
		RequestBody = reqBody;
		RequestHeaders = reqHeaders;
		Channel = httpChan;
		ReqBodyContainsHeaders = bodyContainsHeaders;
	}
}
