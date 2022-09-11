using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DevDefined.OAuth.Framework.Signing;

public class RsaSha1SignatureImplementation : IContextSignatureImplementation
{
	public string MethodName => "RSA-SHA1";

	public void SignContext(IOAuthContext authContext, SigningContext signingContext)
	{
		authContext.Signature = GenerateSignature(authContext, signingContext);
	}

	public bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext)
	{
		if (signingContext.Algorithm == null)
		{
			throw Error.AlgorithmPropertyNotSetOnSigningContext();
		}
		SHA1CryptoServiceProvider hash = GenerateHash(signingContext);
		RSAPKCS1SignatureDeformatter rSAPKCS1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(signingContext.Algorithm);
		rSAPKCS1SignatureDeformatter.SetHashAlgorithm("MD5");
		byte[] rgbSignature = Convert.FromBase64String(authContext.Signature);
		return rSAPKCS1SignatureDeformatter.VerifySignature(hash, rgbSignature);
	}

	private string GenerateSignature(IOAuthContext authContext, SigningContext signingContext)
	{
		if (signingContext.Algorithm == null)
		{
			throw Error.AlgorithmPropertyNotSetOnSigningContext();
		}
		SHA1CryptoServiceProvider hash = GenerateHash(signingContext);
		RSAPKCS1SignatureFormatter rSAPKCS1SignatureFormatter = new RSAPKCS1SignatureFormatter(signingContext.Algorithm);
		rSAPKCS1SignatureFormatter.SetHashAlgorithm("MD5");
		byte[] inArray = rSAPKCS1SignatureFormatter.CreateSignature(hash);
		return Convert.ToBase64String(inArray);
	}

	private SHA1CryptoServiceProvider GenerateHash(SigningContext signingContext)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(signingContext.SignatureBase);
		CryptoStream cryptoStream = new CryptoStream(Stream.Null, sHA1CryptoServiceProvider, CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.Close();
		return sHA1CryptoServiceProvider;
	}
}
