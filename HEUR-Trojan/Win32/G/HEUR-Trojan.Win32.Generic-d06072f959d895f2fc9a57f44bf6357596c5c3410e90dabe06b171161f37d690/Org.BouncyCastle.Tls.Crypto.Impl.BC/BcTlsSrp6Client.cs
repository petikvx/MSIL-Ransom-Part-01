using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsSrp6Client : TlsSrp6Client
{
	private readonly Srp6Client m_srp6Client;

	internal BcTlsSrp6Client(Srp6Client srpClient)
	{
		m_srp6Client = srpClient;
	}

	public BigInteger CalculateSecret(BigInteger serverB)
	{
		try
		{
			return m_srp6Client.CalculateSecret(serverB);
		}
		catch (CryptoException alertCause)
		{
			throw new TlsFatalAlert(47, alertCause);
		}
	}

	public BigInteger GenerateClientCredentials(byte[] srpSalt, byte[] identity, byte[] password)
	{
		return m_srp6Client.GenerateClientCredentials(srpSalt, identity, password);
	}
}
