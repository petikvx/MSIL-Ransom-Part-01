namespace DevDefined.OAuth.Framework.Signing;

public interface IOAuthContextSigner
{
	void SignContext(IOAuthContext authContext, SigningContext signingContext);

	bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext);
}
