using System;
using System.Security.Cryptography;
using System.Text;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Framework.Signing;

public class HmacSha1SignatureImplementation : IContextSignatureImplementation
{
	public string MethodName => "HMAC-SHA1";

	public void SignContext(IOAuthContext authContext, SigningContext signingContext)
	{
		authContext.Signature = GenerateSignature(authContext, signingContext);
	}

	public bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext)
	{
		return authContext.Signature.EqualsInConstantTime(GenerateSignature(authContext, signingContext));
	}

	private static string GenerateSignature(IToken authContext, SigningContext signingContext)
	{
		string arg = ((signingContext.ConsumerSecret != null) ? UriUtility.UrlEncode(signingContext.ConsumerSecret) : "");
		string arg2 = ((authContext.TokenSecret != null) ? UriUtility.UrlEncode(authContext.TokenSecret) : null);
		string s = $"{arg}&{arg2}";
		HMACSHA1 hMACSHA = new HMACSHA1();
		hMACSHA.Key = Encoding.ASCII.GetBytes(s);
		HMACSHA1 hashAlgorithm = hMACSHA;
		return ComputeHash(hashAlgorithm, signingContext.SignatureBase);
	}

	private static string ComputeHash(HashAlgorithm hashAlgorithm, string data)
	{
		if (hashAlgorithm == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (string.IsNullOrEmpty(data))
		{
			throw new ArgumentNullException("data");
		}
		byte[] bytes = Encoding.ASCII.GetBytes(data);
		byte[] inArray = hashAlgorithm.ComputeHash(bytes);
		return Convert.ToBase64String(inArray);
	}
}
