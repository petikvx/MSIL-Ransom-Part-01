using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Framework.Signing;
using DevDefined.OAuth.Storage;

namespace DevDefined.OAuth.Provider.Inspectors;

public class SignatureValidationInspector : IContextInspector
{
	private readonly IConsumerStore _consumerStore;

	private readonly IOAuthContextSigner _signer;

	public SignatureValidationInspector(IConsumerStore consumerStore)
		: this(consumerStore, new OAuthContextSigner())
	{
	}

	public SignatureValidationInspector(IConsumerStore consumerStore, IOAuthContextSigner signer)
	{
		_consumerStore = consumerStore;
		_signer = signer;
	}

	public virtual void InspectContext(ProviderPhase phase, IOAuthContext context)
	{
		SigningContext signingContext = CreateSignatureContextForConsumer(context);
		if (!_signer.ValidateSignature(context, signingContext))
		{
			throw Error.FailedToValidateSignature(context);
		}
	}

	protected virtual bool SignatureMethodRequiresCertificate(string signatureMethod)
	{
		if (signatureMethod != "HMAC-SHA1")
		{
			return signatureMethod != "PLAINTEXT";
		}
		return false;
	}

	protected virtual SigningContext CreateSignatureContextForConsumer(IOAuthContext context)
	{
		SigningContext signingContext = new SigningContext();
		signingContext.ConsumerSecret = _consumerStore.GetConsumerSecret(context);
		SigningContext signingContext2 = signingContext;
		if (SignatureMethodRequiresCertificate(context.SignatureMethod))
		{
			signingContext2.Algorithm = _consumerStore.GetConsumerPublicKey(context);
		}
		return signingContext2;
	}
}
