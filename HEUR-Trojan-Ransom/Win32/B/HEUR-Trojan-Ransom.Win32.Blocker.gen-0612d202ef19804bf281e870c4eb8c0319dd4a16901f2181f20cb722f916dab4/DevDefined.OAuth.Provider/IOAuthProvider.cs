using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Provider;

public interface IOAuthProvider
{
	IToken GrantRequestToken(IOAuthContext context);

	IToken ExchangeRequestTokenForAccessToken(IOAuthContext context);

	void AccessProtectedResourceRequest(IOAuthContext context);

	IToken RenewAccessToken(IOAuthContext context);

	IToken CreateAccessToken(IOAuthContext context);
}
