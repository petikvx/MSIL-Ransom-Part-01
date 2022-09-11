using System;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Storage;

namespace DevDefined.OAuth.Testing;

public class TestTokenStore : ITokenStore
{
	public const string AccessSecret = "accesssecret";

	public const string RequestSecret = "requestsecret";

	public string CallbackUrl { get; set; }

	public string VerificationCode { get; set; }

	public TestTokenStore()
	{
		CallbackUrl = "http://localhost/callback";
		VerificationCode = "GzvVb5WjWfHKa/0JuFupaMyn";
	}

	public IToken CreateRequestToken(IOAuthContext context)
	{
		EnsureTestConsumer(context);
		TokenBase tokenBase = new TokenBase();
		tokenBase.ConsumerKey = "key";
		tokenBase.Realm = null;
		tokenBase.Token = "requestkey";
		tokenBase.TokenSecret = "requestsecret";
		return tokenBase;
	}

	public void ConsumeRequestToken(IOAuthContext requestContext)
	{
		EnsureTestConsumer(requestContext);
		if (requestContext.Token != "requestkey")
		{
			throw new OAuthException(requestContext, "token_rejected", "The supplied request token is unknown to the provider.");
		}
	}

	public void ConsumeAccessToken(IOAuthContext accessContext)
	{
		EnsureTestConsumer(accessContext);
		if (accessContext.Token != "accesskey")
		{
			throw new OAuthException(accessContext, "token_rejected", "The supplied access token is unknown to the provider.");
		}
	}

	public IToken GetAccessTokenAssociatedWithRequestToken(IOAuthContext requestContext)
	{
		EnsureTestConsumer(requestContext);
		if (requestContext.Token != "requestkey")
		{
			throw new OAuthException(requestContext, "token_rejected", "Expected Token \"requestkey\"");
		}
		TokenBase tokenBase = new TokenBase();
		tokenBase.ConsumerKey = "key";
		tokenBase.Realm = null;
		tokenBase.Token = "accesskey";
		tokenBase.TokenSecret = "accesssecret";
		return tokenBase;
	}

	public RequestForAccessStatus GetStatusOfRequestForAccess(IOAuthContext requestContext)
	{
		if (requestContext.ConsumerKey == "key" && requestContext.Token == "requestkey")
		{
			return RequestForAccessStatus.Granted;
		}
		return RequestForAccessStatus.Unknown;
	}

	public string GetCallbackUrlForToken(IOAuthContext requestContext)
	{
		return CallbackUrl;
	}

	public string GetVerificationCodeForRequestToken(IOAuthContext requestContext)
	{
		return VerificationCode;
	}

	public string GetRequestTokenSecret(IOAuthContext context)
	{
		return "requestsecret";
	}

	public string GetAccessTokenSecret(IOAuthContext context)
	{
		return "accesssecret";
	}

	public IToken RenewAccessToken(IOAuthContext requestContext)
	{
		EnsureTestConsumer(requestContext);
		TokenBase tokenBase = new TokenBase();
		tokenBase.ConsumerKey = "key";
		tokenBase.Realm = null;
		tokenBase.Token = "accesskey";
		tokenBase.TokenSecret = "accesssecret";
		tokenBase.SessionHandle = requestContext.SessionHandle;
		return tokenBase;
	}

	public IToken CreateAccessToken(IOAuthContext context)
	{
		EnsureTestConsumer(context);
		TokenBase tokenBase = new TokenBase();
		tokenBase.ConsumerKey = "key";
		tokenBase.Realm = null;
		tokenBase.Token = "accesskey";
		tokenBase.TokenSecret = "accesssecret";
		tokenBase.SessionHandle = "sessionHandle";
		return tokenBase;
	}

	public IToken CreateAccessTokenForRequestToken(IOAuthContext requestContext)
	{
		EnsureTestConsumer(requestContext);
		TokenBase tokenBase = new TokenBase();
		tokenBase.ConsumerKey = "key";
		tokenBase.Realm = null;
		tokenBase.Token = "accesskey";
		tokenBase.TokenSecret = "accesssecret";
		tokenBase.SessionHandle = "sessionHandle";
		return tokenBase;
	}

	private static void EnsureTestConsumer(IConsumer consumer)
	{
		if (consumer == null)
		{
			throw new ArgumentNullException("consumer");
		}
		if (consumer.Realm != null)
		{
			throw new OAuthException(consumer as OAuthContext, "consumer_key_rejected", "supplied realm was unknown to the provider");
		}
		if (consumer.ConsumerKey != "key")
		{
			throw new OAuthException(consumer as OAuthContext, "consumer_key_rejected", "supplied consumer key was unknown to the provider");
		}
	}
}
