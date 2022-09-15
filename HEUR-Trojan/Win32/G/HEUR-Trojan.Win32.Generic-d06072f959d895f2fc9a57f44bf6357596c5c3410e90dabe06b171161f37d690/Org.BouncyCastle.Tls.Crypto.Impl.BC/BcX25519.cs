using System;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcX25519 : TlsAgreement
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly byte[] m_privateKey = new byte[32];

	protected readonly byte[] m_peerPublicKey = new byte[32];

	public BcX25519(BcTlsCrypto crypto)
	{
		m_crypto = crypto;
	}

	public virtual byte[] GenerateEphemeral()
	{
		m_crypto.SecureRandom.NextBytes(m_privateKey);
		byte[] array = new byte[32];
		X25519.ScalarMultBase(m_privateKey, 0, array, 0);
		return array;
	}

	public virtual void ReceivePeerValue(byte[] peerValue)
	{
		if (peerValue == null || peerValue.Length != 32)
		{
			throw new TlsFatalAlert(47);
		}
		Array.Copy(peerValue, 0, m_peerPublicKey, 0, 32);
	}

	public virtual TlsSecret CalculateSecret()
	{
		try
		{
			byte[] array = new byte[32];
			if (!X25519.CalculateAgreement(m_privateKey, 0, m_peerPublicKey, 0, array, 0))
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
