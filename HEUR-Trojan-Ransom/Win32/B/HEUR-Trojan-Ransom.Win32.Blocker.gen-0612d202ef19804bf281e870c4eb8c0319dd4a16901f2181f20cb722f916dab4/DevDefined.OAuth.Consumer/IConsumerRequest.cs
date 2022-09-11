using System;
using System.Collections.Specialized;
using System.Net;
using System.Xml.Linq;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Consumer;

public interface IConsumerRequest
{
	IOAuthConsumerContext ConsumerContext { get; }

	IOAuthContext Context { get; }

	Uri ProxyServerUri { get; set; }

	Action<string> ResponseBodyAction { get; set; }

	string AcceptsType { get; set; }

	int? Timeout { get; set; }

	string RequestBody { get; set; }

	XDocument ToDocument();

	byte[] ToBytes();

	HttpWebRequest ToWebRequest();

	HttpWebResponse ToWebResponse();

	NameValueCollection ToBodyParameters();

	RequestDescription GetRequestDescription();

	IConsumerRequest SignWithoutToken();

	IConsumerRequest SignWithToken();

	IConsumerRequest SignWithToken(IToken token);
}
