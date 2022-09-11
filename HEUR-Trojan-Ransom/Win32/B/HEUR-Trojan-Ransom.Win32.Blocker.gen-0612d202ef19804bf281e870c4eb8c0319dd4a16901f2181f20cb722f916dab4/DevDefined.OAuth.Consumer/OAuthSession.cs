using System;
using System.Collections;
using System.Collections.Specialized;
using System.Web;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Consumer;

[Serializable]
public class OAuthSession : IOAuthSession
{
	private readonly NameValueCollection _cookies = new NameValueCollection();

	private readonly NameValueCollection _formParameters = new NameValueCollection();

	private readonly NameValueCollection _headers = new NameValueCollection();

	private readonly NameValueCollection _queryParameters = new NameValueCollection();

	private IConsumerRequestFactory _consumerRequestFactory = DefaultConsumerRequestFactory.Instance;

	public IConsumerRequestFactory ConsumerRequestFactory
	{
		get
		{
			return _consumerRequestFactory;
		}
		set
		{
			if (_consumerRequestFactory == null)
			{
				throw new ArgumentNullException("value");
			}
			_consumerRequestFactory = value;
		}
	}

	public bool CallbackMustBeConfirmed { get; set; }

	public Uri CallbackUri { get; set; }

	public bool AddBodyHashesToRawRequests { get; set; }

	public Action<string> ResponseBodyAction { get; set; }

	public IOAuthConsumerContext ConsumerContext { get; set; }

	public Uri RequestTokenUri { get; set; }

	public Uri AccessTokenUri { get; set; }

	public Uri UserAuthorizeUri { get; set; }

	public Uri ProxyServerUri { get; set; }

	public IToken AccessToken { get; set; }

	public OAuthSession(IOAuthConsumerContext consumerContext)
		: this(consumerContext, (Uri)null, (Uri)null, (Uri)null, (Uri)null)
	{
	}

	public OAuthSession(IOAuthConsumerContext consumerContext, Uri endPointUri)
		: this(consumerContext, endPointUri, endPointUri, endPointUri, null)
	{
	}

	public OAuthSession(IOAuthConsumerContext consumerContext, Uri requestTokenUri, Uri userAuthorizeUri, Uri accessTokenUri)
		: this(consumerContext, requestTokenUri, userAuthorizeUri, accessTokenUri, null)
	{
	}

	public OAuthSession(IOAuthConsumerContext consumerContext, Uri requestTokenUri, Uri userAuthorizeUri, Uri accessTokenUri, Uri callBackUri)
	{
		ConsumerContext = consumerContext;
		RequestTokenUri = requestTokenUri;
		AccessTokenUri = accessTokenUri;
		UserAuthorizeUri = userAuthorizeUri;
		CallbackUri = callBackUri;
	}

	public OAuthSession(IOAuthConsumerContext consumerContext, string requestTokenUrl, string userAuthorizeUrl, string accessTokenUrl, string callBackUrl)
		: this(consumerContext, new Uri(requestTokenUrl), new Uri(userAuthorizeUrl), new Uri(accessTokenUrl), ParseCallbackUri(callBackUrl))
	{
	}

	public OAuthSession(IOAuthConsumerContext consumerContext, string requestTokenUrl, string userAuthorizeUrl, string accessTokenUrl)
		: this(consumerContext, requestTokenUrl, userAuthorizeUrl, accessTokenUrl, null)
	{
	}

	public IConsumerRequest Request(IToken accessToken)
	{
		OAuthContext oAuthContext = new OAuthContext();
		oAuthContext.UseAuthorizationHeader = ConsumerContext.UseHeaderForOAuthParameters;
		oAuthContext.IncludeOAuthRequestBodyHashInSignature = AddBodyHashesToRawRequests;
		OAuthContext oAuthContext2 = oAuthContext;
		oAuthContext2.Cookies.Add(_cookies);
		oAuthContext2.FormEncodedParameters.Add(_formParameters);
		oAuthContext2.Headers.Add(_headers);
		oAuthContext2.QueryParameters.Add(_queryParameters);
		IConsumerRequest consumerRequest = _consumerRequestFactory.CreateConsumerRequest(oAuthContext2, ConsumerContext, accessToken);
		consumerRequest.ProxyServerUri = ProxyServerUri;
		consumerRequest.ResponseBodyAction = ResponseBodyAction;
		return consumerRequest;
	}

	public IConsumerRequest Request()
	{
		OAuthContext oAuthContext = new OAuthContext();
		oAuthContext.UseAuthorizationHeader = ConsumerContext.UseHeaderForOAuthParameters;
		oAuthContext.IncludeOAuthRequestBodyHashInSignature = AddBodyHashesToRawRequests;
		OAuthContext oAuthContext2 = oAuthContext;
		oAuthContext2.Cookies.Add(_cookies);
		oAuthContext2.FormEncodedParameters.Add(_formParameters);
		oAuthContext2.Headers.Add(_headers);
		oAuthContext2.QueryParameters.Add(_queryParameters);
		IConsumerRequest consumerRequest = _consumerRequestFactory.CreateConsumerRequest(oAuthContext2, ConsumerContext, AccessToken);
		consumerRequest.ProxyServerUri = ProxyServerUri;
		consumerRequest.ResponseBodyAction = ResponseBodyAction;
		return consumerRequest;
	}

	public IToken GetRequestToken()
	{
		return GetRequestToken("GET");
	}

	public IToken ExchangeRequestTokenForAccessToken(IToken requestToken)
	{
		return ExchangeRequestTokenForAccessToken(requestToken, "GET", null);
	}

	public IToken ExchangeRequestTokenForAccessToken(IToken requestToken, string verificationCode)
	{
		return ExchangeRequestTokenForAccessToken(requestToken, "GET", verificationCode);
	}

	public IToken ExchangeRequestTokenForAccessToken(IToken requestToken, string method, string verificationCode)
	{
		return AccessToken = from collection in BuildExchangeRequestTokenForAccessTokenContext(requestToken, method, verificationCode)
			select new TokenBase
			{
				ConsumerKey = requestToken.ConsumerKey,
				Token = ParseResponseParameter(collection, "oauth_token"),
				TokenSecret = ParseResponseParameter(collection, "oauth_token_secret"),
				SessionHandle = ParseResponseParameter(collection, "oauth_session_handle")
			};
	}

	public IToken GetAccessTokenUsingXAuth(string authMode, string username, string password)
	{
		return AccessToken = from collection in BuildAccessTokenContext("GET", authMode, username, password)
			select new TokenBase
			{
				ConsumerKey = ConsumerContext.ConsumerKey,
				Token = ParseResponseParameter(collection, "oauth_token"),
				TokenSecret = ParseResponseParameter(collection, "oauth_token_secret"),
				SessionHandle = ParseResponseParameter(collection, "oauth_session_handle")
			};
	}

	public IConsumerRequest BuildRequestTokenContext(string method)
	{
		return Request().ForMethod(method).AlterContext(delegate(IOAuthContext context)
		{
			context.CallbackUrl = ((CallbackUri == null) ? "oob" : CallbackUri.ToString());
		}).AlterContext(delegate(IOAuthContext context)
		{
			context.Token = null;
		})
			.ForUri(RequestTokenUri)
			.SignWithoutToken();
	}

	public IConsumerRequest BuildExchangeRequestTokenForAccessTokenContext(IToken requestToken, string method, string verificationCode)
	{
		return Request().ForMethod(method).AlterContext(delegate(IOAuthContext context)
		{
			context.Verifier = verificationCode;
		}).ForUri(AccessTokenUri)
			.SignWithToken(requestToken);
	}

	public IConsumerRequest BuildAccessTokenContext(string method, string xAuthMode, string xAuthUsername, string xAuthPassword)
	{
		return Request().ForMethod(method).AlterContext(delegate(IOAuthContext context)
		{
			context.XAuthUsername = xAuthUsername;
		}).AlterContext(delegate(IOAuthContext context)
		{
			context.XAuthPassword = xAuthPassword;
		})
			.AlterContext(delegate(IOAuthContext context)
			{
				context.XAuthMode = xAuthMode;
			})
			.ForUri(AccessTokenUri)
			.SignWithoutToken();
	}

	public string GetUserAuthorizationUrlForToken(IToken token)
	{
		return GetUserAuthorizationUrlForToken(token, null);
	}

	public string GetUserAuthorizationUrlForToken(IToken token, string callbackUrl)
	{
		UriBuilder uriBuilder = new UriBuilder(UserAuthorizeUri);
		NameValueCollection nameValueCollection = new NameValueCollection();
		if (uriBuilder.Query != null)
		{
			nameValueCollection.Add(HttpUtility.ParseQueryString(uriBuilder.Query));
		}
		if (_queryParameters != null)
		{
			nameValueCollection.Add(_queryParameters);
		}
		nameValueCollection["oauth_token"] = token.Token;
		if (!string.IsNullOrEmpty(callbackUrl))
		{
			nameValueCollection["oauth_callback"] = callbackUrl;
		}
		uriBuilder.Query = "";
		return string.Concat(uriBuilder.Uri, "?", UriUtility.FormatQueryString(nameValueCollection));
	}

	public IOAuthSession WithFormParameters(IDictionary dictionary)
	{
		return AddItems(_formParameters, dictionary);
	}

	public IOAuthSession WithFormParameters(object anonymousClass)
	{
		return AddItems(_formParameters, anonymousClass);
	}

	public IOAuthSession WithQueryParameters(IDictionary dictionary)
	{
		return AddItems(_queryParameters, dictionary);
	}

	public IOAuthSession WithQueryParameters(object anonymousClass)
	{
		return AddItems(_queryParameters, anonymousClass);
	}

	public IOAuthSession WithCookies(IDictionary dictionary)
	{
		return AddItems(_cookies, dictionary);
	}

	public IOAuthSession WithCookies(object anonymousClass)
	{
		return AddItems(_cookies, anonymousClass);
	}

	public IOAuthSession WithHeaders(IDictionary dictionary)
	{
		return AddItems(_headers, dictionary);
	}

	public IOAuthSession WithHeaders(object anonymousClass)
	{
		return AddItems(_headers, anonymousClass);
	}

	public IOAuthSession RequiresCallbackConfirmation()
	{
		CallbackMustBeConfirmed = true;
		return this;
	}

	public IToken RenewAccessToken(IToken accessToken, string sessionHandle)
	{
		return RenewAccessToken(accessToken, "GET", sessionHandle);
	}

	public IToken RenewAccessToken(IToken accessToken, string method, string sessionHandle)
	{
		return AccessToken = from collection in BuildRenewAccessTokenContext(accessToken, method, sessionHandle)
			select new TokenBase
			{
				ConsumerKey = accessToken.ConsumerKey,
				Token = ParseResponseParameter(collection, "oauth_token"),
				TokenSecret = ParseResponseParameter(collection, "oauth_token_secret"),
				SessionHandle = ParseResponseParameter(collection, "oauth_session_handle")
			};
	}

	public IConsumerRequest BuildRenewAccessTokenContext(IToken requestToken, string method, string sessionHandle)
	{
		return Request().ForMethod(method).AlterContext(delegate(IOAuthContext context)
		{
			context.SessionHandle = sessionHandle;
		}).ForUri(AccessTokenUri)
			.SignWithToken(requestToken);
	}

	public IToken GetRequestToken(string method)
	{
		var anon = from collection in BuildRequestTokenContext(method)
			select new
			{
				ConsumerKey = ConsumerContext.ConsumerKey,
				Token = ParseResponseParameter(collection, "oauth_token"),
				TokenSecret = ParseResponseParameter(collection, "oauth_token_secret"),
				CallackConfirmed = WasCallbackConfimed(collection)
			};
		if (!anon.CallackConfirmed && CallbackMustBeConfirmed)
		{
			throw Error.CallbackWasNotConfirmed();
		}
		TokenBase tokenBase = new TokenBase();
		tokenBase.ConsumerKey = anon.ConsumerKey;
		tokenBase.Token = anon.Token;
		tokenBase.TokenSecret = anon.TokenSecret;
		return tokenBase;
	}

	private static bool WasCallbackConfimed(NameValueCollection parameters)
	{
		string text = ParseResponseParameter(parameters, "oauth_callback_confirmed");
		return text == "true";
	}

	private static Uri ParseCallbackUri(string callBackUrl)
	{
		if (string.IsNullOrEmpty(callBackUrl))
		{
			return null;
		}
		if (callBackUrl.Equals("oob", StringComparison.InvariantCultureIgnoreCase))
		{
			return null;
		}
		return new Uri(callBackUrl);
	}

	private static string ParseResponseParameter(NameValueCollection collection, string parameter)
	{
		string text = (collection[parameter] ?? "")!.Trim();
		if (text.Length <= 0)
		{
			return null;
		}
		return text;
	}

	private OAuthSession AddItems(NameValueCollection destination, object anonymousClass)
	{
		return AddItems(destination, new ReflectionBasedDictionaryAdapter(anonymousClass));
	}

	private OAuthSession AddItems(NameValueCollection destination, IDictionary additions)
	{
		foreach (string key in additions.Keys)
		{
			destination[key] = Convert.ToString(additions[key]);
		}
		return this;
	}

	public IOAuthSession EnableOAuthRequestBodyHashes()
	{
		AddBodyHashesToRawRequests = true;
		return this;
	}
}
