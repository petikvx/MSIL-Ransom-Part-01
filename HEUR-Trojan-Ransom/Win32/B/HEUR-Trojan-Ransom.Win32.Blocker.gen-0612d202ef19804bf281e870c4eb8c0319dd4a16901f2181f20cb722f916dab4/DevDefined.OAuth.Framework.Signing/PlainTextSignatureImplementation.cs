using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Framework.Signing;

public class PlainTextSignatureImplementation : IContextSignatureImplementation
{
	public string MethodName => "PLAINTEXT";

	public void SignContext(IOAuthContext authContext, SigningContext signingContext)
	{
		authContext.Signature = GenerateSignature(authContext, signingContext);
	}

	public bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext)
	{
		return authContext.Signature.EqualsInConstantTime(GenerateSignature(authContext, signingContext));
	}

	private string GenerateSignature(IOAuthContext authContext, SigningContext signingContext)
	{
		return UriUtility.UrlEncode($"{signingContext.ConsumerSecret}&{authContext.TokenSecret}");
	}
}
