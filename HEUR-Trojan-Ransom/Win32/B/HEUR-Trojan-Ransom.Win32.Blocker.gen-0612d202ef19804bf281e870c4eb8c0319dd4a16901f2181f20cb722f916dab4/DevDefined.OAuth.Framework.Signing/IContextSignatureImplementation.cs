namespace DevDefined.OAuth.Framework.Signing;

public interface IContextSignatureImplementation
{
	string MethodName { get; }

	void SignContext(IOAuthContext authContext, SigningContext signingContext);

	bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext);
}
