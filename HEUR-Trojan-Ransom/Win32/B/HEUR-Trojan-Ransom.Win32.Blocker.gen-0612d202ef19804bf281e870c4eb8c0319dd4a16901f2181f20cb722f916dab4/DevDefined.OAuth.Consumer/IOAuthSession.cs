using System;
using System.Collections;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Consumer;

public interface IOAuthSession
{
	IOAuthConsumerContext ConsumerContext { get; set; }

	Uri RequestTokenUri { get; set; }

	Uri AccessTokenUri { get; set; }

	Uri UserAuthorizeUri { get; set; }

	Uri ProxyServerUri { get; set; }

	IToken AccessToken { get; set; }

	Action<string> ResponseBodyAction { get; set; }

	IConsumerRequest Request();

	IConsumerRequest Request(IToken accessToken);

	IToken GetRequestToken();

	IToken GetRequestToken(string method);

	IToken ExchangeRequestTokenForAccessToken(IToken requestToken);

	IToken ExchangeRequestTokenForAccessToken(IToken requestToken, string verificationCode);

	IToken ExchangeRequestTokenForAccessToken(IToken requestToken, string method, string verificationCode);

	IToken GetAccessTokenUsingXAuth(string authMode, string username, string password);

	IConsumerRequest BuildRequestTokenContext(string method);

	IConsumerRequest BuildExchangeRequestTokenForAccessTokenContext(IToken requestToken, string method, string verificationCode);

	IConsumerRequest BuildAccessTokenContext(string method, string xAuthMode, string xAuthUsername, string xAuthPassword);

	string GetUserAuthorizationUrlForToken(IToken token, string callbackUrl);

	string GetUserAuthorizationUrlForToken(IToken token);

	IOAuthSession WithFormParameters(IDictionary dictionary);

	IOAuthSession WithFormParameters(object anonymousClass);

	IOAuthSession WithQueryParameters(IDictionary dictionary);

	IOAuthSession WithQueryParameters(object anonymousClass);

	IOAuthSession WithCookies(IDictionary dictionary);

	IOAuthSession WithCookies(object anonymousClass);

	IOAuthSession WithHeaders(IDictionary dictionary);

	IOAuthSession WithHeaders(object anonymousClass);

	IOAuthSession RequiresCallbackConfirmation();
}
