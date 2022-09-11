using System;
using System.Collections.Generic;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Provider.Inspectors;
using DevDefined.OAuth.Storage;

namespace DevDefined.OAuth.Provider;

public class OAuthProvider : IOAuthProvider
{
	private readonly List<IContextInspector> _inspectors = new List<IContextInspector>();

	private readonly ITokenStore _tokenStore;

	public bool RequiresCallbackUrlInRequest { get; set; }

	public OAuthProvider(ITokenStore tokenStore, params IContextInspector[] inspectors)
	{
		RequiresCallbackUrlInRequest = true;
		if (tokenStore == null)
		{
			throw new ArgumentNullException("tokenStore");
		}
		_tokenStore = tokenStore;
		if (inspectors != null)
		{
			_inspectors.AddRange(inspectors);
		}
	}

	public virtual IToken GrantRequestToken(IOAuthContext context)
	{
		AssertContextDoesNotIncludeToken(context);
		InspectRequest(ProviderPhase.GrantRequestToken, context);
		return _tokenStore.CreateRequestToken(context);
	}

	public virtual IToken ExchangeRequestTokenForAccessToken(IOAuthContext context)
	{
		InspectRequest(ProviderPhase.ExchangeRequestTokenForAccessToken, context);
		_tokenStore.ConsumeRequestToken(context);
		return _tokenStore.GetStatusOfRequestForAccess(context) switch
		{
			RequestForAccessStatus.Unknown => throw Error.ConsumerHasNotBeenGrantedAccessYet(context), 
			RequestForAccessStatus.Granted => _tokenStore.GetAccessTokenAssociatedWithRequestToken(context), 
			_ => throw Error.ConsumerHasBeenDeniedAccess(context), 
		};
	}

	public virtual void AccessProtectedResourceRequest(IOAuthContext context)
	{
		InspectRequest(ProviderPhase.AccessProtectedResourceRequest, context);
		_tokenStore.ConsumeAccessToken(context);
	}

	public IToken RenewAccessToken(IOAuthContext context)
	{
		InspectRequest(ProviderPhase.RenewAccessToken, context);
		return _tokenStore.RenewAccessToken(context);
	}

	public IToken CreateAccessToken(IOAuthContext context)
	{
		InspectRequest(ProviderPhase.CreateAccessToken, context);
		return _tokenStore.CreateAccessToken(context);
	}

	private void AssertContextDoesNotIncludeToken(IOAuthContext context)
	{
		if (context.Token != null)
		{
			throw Error.RequestForTokenMustNotIncludeTokenInContext(context);
		}
	}

	public void AddInspector(IContextInspector inspector)
	{
		_inspectors.Add(inspector);
	}

	protected virtual void InspectRequest(ProviderPhase phase, IOAuthContext context)
	{
		AssertContextDoesNotIncludeTokenSecret(context);
		AddStoredTokenSecretToContext(context, phase);
		ApplyInspectors(context, phase);
	}

	private void ApplyInspectors(IOAuthContext context, ProviderPhase phase)
	{
		foreach (IContextInspector inspector in _inspectors)
		{
			inspector.InspectContext(phase, context);
		}
	}

	private void AddStoredTokenSecretToContext(IOAuthContext context, ProviderPhase phase)
	{
		switch (phase)
		{
		case ProviderPhase.ExchangeRequestTokenForAccessToken:
		{
			string text2 = (context.TokenSecret = _tokenStore.GetRequestTokenSecret(context));
			break;
		}
		case ProviderPhase.AccessProtectedResourceRequest:
		case ProviderPhase.RenewAccessToken:
		{
			string text = (context.TokenSecret = _tokenStore.GetAccessTokenSecret(context));
			break;
		}
		}
	}

	private static void AssertContextDoesNotIncludeTokenSecret(IOAuthContext context)
	{
		if (!string.IsNullOrEmpty(context.TokenSecret))
		{
			throw new OAuthException(context, "parameter_rejected", "The oauth_token_secret must not be transmitted to the provider.");
		}
	}
}
