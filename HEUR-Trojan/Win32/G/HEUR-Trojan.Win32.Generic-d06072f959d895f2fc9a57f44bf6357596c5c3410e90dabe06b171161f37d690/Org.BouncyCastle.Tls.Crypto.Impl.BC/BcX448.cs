using System;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcX448 : TlsAgreement
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly byte[] m_privateKey = new byte[56];

	protected readonly byte[] m_peerPublicKey = new byte[56];

	public BcX448(BcTlsCrypto crypto)
	{
		m_crypto = crypto;
	}

	public virtual byte[] GenerateEphemeral()
	{
		m_crypto.SecureRandom.NextBytes(m_privateKey);
		byte[] array = new byte[56];
		X448.ScalarMultBase(m_privateKey, 0, array, 0);
		return array;
	}

	public virtual void ReceivePeerValue(byte[] peerValue)
	{
		if (peerValue == null || peerValue.Length != 56)
		{
			throw new TlsFatalAlert(47);
		}
		Array.Copy(peerValue, 0, m_peerPublicKey, 0, 56);
	}

	public virtual TlsSecret CalculateSecret()
	{
		try
		{
			byte[] array = new byte[56];
			if (!X448.CalculateAgreement(m_privateKey, 0, m_peerPublicKey, 0, array, 0))
			{
				throw new TlsFatalAlert(40);
			}
			return m_crypto.AdoptLocalSecret(array);
		}
		finally
		{
			Array.Clear(m_privateKey, 0, m_privateKey.Length);
			Array.Clear(m_peerPublicKey, 0, m_peerPublicKey.Length);
		}
	}
}
