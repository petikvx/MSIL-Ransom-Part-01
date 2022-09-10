using System.Security.Cryptography;

namespace Microsoft.InfoCards;

internal class SelfIssuedAuthRSAPKCS1SignatureFormatter : RSAPKCS1SignatureFormatter
{
	private RSA m_rsaKey;

	private string m_strOID;

	public SelfIssuedAuthRSAPKCS1SignatureFormatter()
	{
	}

	public SelfIssuedAuthRSAPKCS1SignatureFormatter(AsymmetricAlgorithm key)
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

	public override byte[] CreateSignature(byte[] rgbHash)
	{
		if (m_strOID != null && m_rsaKey != null && rgbHash != null && m_rsaKey is SelfIssuedAuthRSACryptoProvider)
		{
			return ((SelfIssuedAuthRSACryptoProvider)m_rsaKey).SignHash(rgbHash, m_strOID);
		}
		return base.CreateSignature(rgbHash);
	}
}
