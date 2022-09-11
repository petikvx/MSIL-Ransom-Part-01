using System;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Storage;

namespace DevDefined.OAuth.Provider.Inspectors;

public class OAuth10AInspector : IContextInspector
{
	private readonly ITokenStore _tokenStore;

	public OAuth10AInspector(ITokenStore tokenStore)
	{
		if (tokenStore == null)
		{
			throw new ArgumentNullException("tokenStore");
		}
		_tokenStore = tokenStore;
	}

	public void InspectContext(ProviderPhase phase, IOAuthContext context)
	{
		switch (phase)
		{
		case ProviderPhase.GrantRequestToken:
			ValidateCallbackUrlIsPartOfRequest(context);
			break;
		case ProviderPhase.ExchangeRequestTokenForAccessToken:
			ValidateVerifierMatchesStoredVerifier(context);
			break;
		}
	}

	private void ValidateVerifierMatchesStoredVerifier(IOAuthContext context)
	{
		string verifier = context.Verifier;
		if (string.IsNullOrEmpty(verifier))
		{
			throw Error.MissingRequiredOAuthParameter(context, "oauth_verifier");
		}
		string verificationCodeForRequestToken = _tokenStore.GetVerificationCodeForRequestToken(context);
		if (verificationCodeForRequestToken != verifier.Trim())
		{
			throw Error.RejectedRequiredOAuthParameter(context, "oauth_verifier");
		}
	}

	private static void ValidateCallbackUrlIsPartOfRequest(IOAuthContext context)
	{
		if (string.IsNullOrEmpty(context.CallbackUrl))
		{
			throw Error.MissingRequiredOAuthParameter(context, "oauth_callback");
		}
	}
}
