using System;

namespace DevDefined.OAuth.Framework;

[Serializable]
public class TokenBase : IConsumer, IToken
{
	public string TokenSecret { get; set; }

	public string Token { get; set; }

	public string SessionHandle { get; set; }

	public string ConsumerKey { get; set; }

	public string Realm { get; set; }

	public override string ToString()
	{
		return UriUtility.FormatTokenForResponse(this);
	}
}
