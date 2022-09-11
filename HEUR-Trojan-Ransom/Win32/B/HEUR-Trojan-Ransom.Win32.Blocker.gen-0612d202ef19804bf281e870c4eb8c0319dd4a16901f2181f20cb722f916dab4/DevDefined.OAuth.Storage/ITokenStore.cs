using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage;

public interface ITokenStore
{
	IToken CreateRequestToken(IOAuthContext context);

	IToken CreateAccessToken(IOAuthContext context);

	void ConsumeRequestToken(IOAuthContext requestContext);

	void ConsumeAccessToken(IOAuthContext accessContext);

	IToken GetAccessTokenAssociatedWithRequestToken(IOAuthContext requestContext);

	RequestForAccessStatus GetStatusOfRequestForAccess(IOAuthContext requestContext);

	string GetCallbackUrlForToken(IOAuthContext requestContext);

	string GetVerificationCodeForRequestToken(IOAuthContext requestContext);

	string GetRequestTokenSecret(IOAuthContext context);

	string GetAccessTokenSecret(IOAuthContext context);

	IToken RenewAccessToken(IOAuthContext requestContext);
}
