using System;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RemoteAsymmetricSignatureFormatter : AsymmetricSignatureFormatter
{
	private RemoteCryptoRsaServiceProvider m_rsa;

	private string m_hashOidString;

	private int m_nativeHashType;

	public override byte[] CreateSignature(byte[] rgbHash)
	{
		if (m_rsa == null)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentException("m_rsa"));
		}
		if (string.IsNullOrEmpty(m_hashOidString))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentException("m_hashOidString"));
		}
		if (rgbHash == null)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentNullException("rgbHash"));
		}
		return m_rsa.SignHash(m_nativeHashType, rgbHash);
	}

	public override void SetHashAlgorithm(string strName)
	{
		m_hashOidString = CryptoConfig.MapNameToOID(strName);
		m_nativeHashType = NativeMcppMethods.CryptAlgIdFromOid(m_hashOidString);
	}

	public override void SetKey(AsymmetricAlgorithm key)
	{
		m_rsa = key as RemoteCryptoRsaServiceProvider;
		if (m_rsa == null)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
	}
}
