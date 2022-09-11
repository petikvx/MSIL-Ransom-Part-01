using System.Collections.Generic;
using System.Linq;

namespace DevDefined.OAuth.Framework.Signing;

public class OAuthContextSigner : IOAuthContextSigner
{
	private readonly List<IContextSignatureImplementation> _implementations = new List<IContextSignatureImplementation>();

	public OAuthContextSigner(params IContextSignatureImplementation[] implementations)
	{
		if (implementations != null)
		{
			_implementations.AddRange(implementations);
		}
	}

	public OAuthContextSigner()
		: this(new RsaSha1SignatureImplementation(), new HmacSha1SignatureImplementation(), new PlainTextSignatureImplementation())
	{
	}

	public void SignContext(IOAuthContext authContext, SigningContext signingContext)
	{
		signingContext.SignatureBase = authContext.GenerateSignatureBase();
		FindImplementationForAuthContext(authContext).SignContext(authContext, signingContext);
	}

	public bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext)
	{
		signingContext.SignatureBase = authContext.GenerateSignatureBase();
		return FindImplementationForAuthContext(authContext).ValidateSignature(authContext, signingContext);
	}

	private IContextSignatureImplementation FindImplementationForAuthContext(IOAuthContext authContext)
	{
		IContextSignatureImplementation contextSignatureImplementation = _implementations.FirstOrDefault((IContextSignatureImplementation i) => i.MethodName == authContext.SignatureMethod);
		if (contextSignatureImplementation == null)
		{
			throw Error.UnknownSignatureMethod(authContext.SignatureMethod);
		}
		return contextSignatureImplementation;
	}
}
