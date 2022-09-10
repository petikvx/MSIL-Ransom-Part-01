using System.Security.Cryptography;

namespace Microsoft.InfoCards;

internal class SelfIssuedAuthRSAPKCS1SignatureDeformatter : RSAPKCS1SignatureDeformatter
{
	private RSA m_rsaKey;

	private string m_strOID;

	public SelfIssuedAuthRSAPKCS1SignatureDeformatter()
	{
	}

	public SelfIssuedAuthRSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		: base(key)
	{
		m_rsaKey = (RSA)key;
	}

	public override void SetKey(AsymmetricAlgorithm key)
	{
		base.SetKey(key);
		m_rsaKey = (RSA)key;
	}

	public override void SetHashAlgorithm(string strName)
	{
		base.SetHashAlgorithm(strName);
		m_strOID = CryptoConfig.MapNameToOID(strName);
	}

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
	{
		if (m_strOID != null && m_rsaKey != null && rgbHash != null && rgbSignature != null && m_rsaKey is SelfIssuedAuthRSACryptoProvider)
		{
			return ((SelfIssuedAuthRSACryptoProvider)m_rsaKey).VerifyHash(rgbHash, m_strOID, rgbSignature);
		}
		return base.VerifySignature(rgbHash, rgbSignature);
	}
}
