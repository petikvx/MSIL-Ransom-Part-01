using System;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SelfIssuedAuthAsymmetricKey : AsymmetricSecurityKey, IDisposable
{
	private SelfIssuedAuthRSACryptoProvider m_selfIssuedAuthRsaCryptoProvider;

	public override int KeySize => m_selfIssuedAuthRsaCryptoProvider.KeySize;

	public SelfIssuedAuthAsymmetricKey(RSACryptoServiceProvider rsa)
	{
		m_selfIssuedAuthRsaCryptoProvider = new SelfIssuedAuthRSACryptoProvider(rsa);
	}

	public override bool HasPrivateKey()
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(m_selfIssuedAuthRsaCryptoProvider.IsPublicOnly(), "selfIssuedRsaCrypoProvider");
		return true;
	}

	public override AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithmUri, bool privateKey)
	{
		switch (algorithmUri)
		{
		default:
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException(SR.GetString("ClientUnsupportedCryptoAlgorithm", new object[1] { algorithmUri })));
		case "http://www.w3.org/2000/09/xmldsig#rsa-sha1":
		case "http://www.w3.org/2001/04/xmlenc#rsa-1_5":
		case "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p":
			return m_selfIssuedAuthRsaCryptoProvider;
		}
	}

	public override HashAlgorithm GetHashAlgorithmForSignature(string algorithmUri)
	{
		string text;
		if ((text = algorithmUri) == null || !(text == "http://www.w3.org/2000/09/xmldsig#rsa-sha1"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException(SR.GetString("UnsupportedSignatureAlgorithm", new object[1] { algorithmUri })));
		}
		return new SHA1Managed();
	}

	public override AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithmUri)
	{
		string text;
		if ((text = algorithmUri) == null || !(text == "http://www.w3.org/2000/09/xmldsig#rsa-sha1"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException(SR.GetString("UnsupportedSignatureAlgorithm", new object[1] { algorithmUri })));
		}
		return new SelfIssuedAuthRSAPKCS1SignatureDeformatter(m_selfIssuedAuthRsaCryptoProvider);
	}

	public override AsymmetricSignatureFormatter GetSignatureFormatter(string algorithmUri)
	{
		string text;
		if ((text = algorithmUri) == null || !(text == "http://www.w3.org/2000/09/xmldsig#rsa-sha1"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException(SR.GetString("UnsupportedSignatureAlgorithm", new object[1] { algorithmUri })));
		}
		return new SelfIssuedAuthRSAPKCS1SignatureFormatter(m_selfIssuedAuthRsaCryptoProvider);
	}

	public override byte[] DecryptKey(string algorithmUri, byte[] keyData)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public override byte[] EncryptKey(string algorithmUri, byte[] keyData)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public override bool IsSupportedAlgorithm(string algorithmUri)
	{
		switch (algorithmUri)
		{
		case "http://www.w3.org/2000/09/xmldsig#rsa-sha1":
		case "http://www.w3.org/2001/04/xmlenc#rsa-1_5":
		case "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p":
			return true;
		default:
			return false;
		}
	}

	public override bool IsSymmetricAlgorithm(string algorithmUri)
	{
		return InfoCardCryptoHelper.IsSymmetricAlgorithm(algorithmUri);
	}

	public override bool IsAsymmetricAlgorithm(string algorithmUri)
	{
		return InfoCardCryptoHelper.IsAsymmetricAlgorithm(algorithmUri);
	}

	public void Dispose()
	{
		if (m_selfIssuedAuthRsaCryptoProvider != null)
		{
			((IDisposable)m_selfIssuedAuthRsaCryptoProvider).Dispose();
			m_selfIssuedAuthRsaCryptoProvider = null;
		}
	}
}
