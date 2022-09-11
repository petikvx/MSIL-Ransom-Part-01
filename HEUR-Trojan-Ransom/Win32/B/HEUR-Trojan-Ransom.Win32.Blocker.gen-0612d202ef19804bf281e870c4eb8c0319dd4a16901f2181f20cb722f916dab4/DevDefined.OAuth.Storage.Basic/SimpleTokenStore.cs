using System;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Storage.Basic;

public class SimpleTokenStore : ITokenStore
{
	private readonly ITokenRepository<AccessToken> _accessTokenRepository;

	private readonly ITokenRepository<RequestToken> _requestTokenRepository;

	public SimpleTokenStore(ITokenRepository<AccessToken> accessTokenRepository, ITokenRepository<RequestToken> requestTokenRepository)
	{
		if (accessTokenRepository == null)
		{
			throw new ArgumentNullException("accessTokenRepository");
		}
		if (requestTokenRepository == null)
		{
			throw new ArgumentNullException("requestTokenRepository");
		}
		_accessTokenRepository = accessTokenRepository;
		_requestTokenRepository = requestTokenRepository;
	}

	public IToken CreateRequestToken(IOAuthContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		RequestToken requestToken = new RequestToken();
		requestToken.ConsumerKey = context.ConsumerKey;
		requestToken.Realm = context.Realm;
		requestToken.Token = Guid.NewGuid().ToString();
		requestToken.TokenSecret = Guid.NewGuid().ToString();
		requestToken.CallbackUrl = context.CallbackUrl;
		RequestToken requestToken2 = requestToken;
		_requestTokenRepository.SaveToken(requestToken2);
		return requestToken2;
	}

	public IToken CreateAccessToken(IOAuthContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		AccessToken accessToken = new AccessToken();
		accessToken.ConsumerKey = context.ConsumerKey;
		accessToken.ExpiryDate = DateTime.UtcNow.AddDays(20.0);
		accessToken.Realm = context.Realm;
		accessToken.Token = Guid.NewGuid().ToString();
		accessToken.TokenSecret = Guid.NewGuid().ToString();
		accessToken.UserName = Guid.NewGuid().ToString();
		AccessToken accessToken2 = accessToken;
		_accessTokenRepository.SaveToken(accessToken2);
		return accessToken2;
	}

	public void ConsumeRequestToken(IOAuthContext requestContext)
	{
		if (requestContext == null)
		{
			throw new ArgumentNullException("requestContext");
		}
		RequestToken requestToken = GetRequestToken(requestContext);
		UseUpRequestToken(requestContext, requestToken);
		_requestTokenRepository.SaveToken(requestToken);
	}

	public void ConsumeAccessToken(IOAuthContext accessContext)
	{
		AccessToken accessToken = GetAccessToken(accessContext);
		if (accessToken.ExpiryDate < Clock.Now)
		{
			throw new OAuthException(accessContext, "token_expired", "Token has expired");
		}
	}

	public IToken GetAccessTokenAssociatedWithRequestToken(IOAuthContext requestContext)
	{
		RequestToken requestToken = GetRequestToken(requestContext);
		return requestToken.AccessToken;
	}

	public RequestForAccessStatus GetStatusOfRequestForAccess(IOAuthContext accessContext)
	{
		RequestToken requestToken = GetRequestToken(accessContext);
		if (requestToken.AccessDenied)
		{
			return RequestForAccessStatus.Denied;
		}
		if (requestToken.AccessToken == null)
		{
			return RequestForAccessStatus.Unknown;
		}
		return RequestForAccessStatus.Granted;
	}

	public string GetCallbackUrlForToken(IOAuthContext requestContext)
	{
		RequestToken requestToken = GetRequestToken(requestContext);
		return requestToken.CallbackUrl;
	}

	public string GetVerificationCodeForRequestToken(IOAuthContext requestContext)
	{
		RequestToken requestToken = GetRequestToken(requestContext);
		return requestToken.Verifier;
	}

	public string GetRequestTokenSecret(IOAuthContext context)
	{
		RequestToken requestToken = GetRequestToken(context);
		return requestToken.TokenSecret;
	}

	public string GetAccessTokenSecret(IOAuthContext context)
	{
		AccessToken accessToken = GetAccessToken(context);
		return accessToken.TokenSecret;
	}

	public IToken RenewAccessToken(IOAuthContext requestContext)
	{
		throw new NotImplementedException();
	}

	private RequestToken GetRequestToken(IOAuthContext context)
	{
		try
		{
			return _requestTokenRepository.GetToken(context.Token);
		}
		catch (Exception exception)
		{
			throw Error.UnknownToken(context, context.Token, exception);
		}
	}

	private AccessToken GetAccessToken(IOAuthContext context)
	{
		try
		{
			return _accessTokenRepository.GetToken(context.Token);
		}
		catch (Exception exception)
		{
			throw Error.UnknownToken(context, context.Token, exception);
		}
	}

	public IToken GetToken(IOAuthContext context)
	{
		IToken result = null;
		if (!string.IsNullOrEmpty(context.Token))
		{
			try
			{
				return (IToken)(((object)_accessTokenRepository.GetToken(context.Token)) ?? ((object)_requestTokenRepository.GetToken(context.Token)));
			}
			catch (Exception exception)
			{
				throw Error.UnknownToken(context, context.Token, exception);
			}
		}
		return result;
	}

	private static void UseUpRequestToken(IOAuthContext requestContext, RequestToken requestToken)
	{
		if (requestToken.UsedUp)
		{
			throw new OAuthException(requestContext, "token_rejected", "The request token has already be consumed.");
		}
		requestToken.UsedUp = true;
	}
}
