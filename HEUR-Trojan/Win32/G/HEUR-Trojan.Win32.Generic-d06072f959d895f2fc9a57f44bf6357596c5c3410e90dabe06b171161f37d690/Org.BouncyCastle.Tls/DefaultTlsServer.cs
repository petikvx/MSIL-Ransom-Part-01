using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public abstract class DefaultTlsServer : AbstractTlsServer
{
	private static readonly int[] DefaultCipherSuites = new int[20]
	{
		52392, 49200, 49199, 49192, 49191, 49172, 49171, 52394, 159, 158,
		107, 103, 57, 51, 157, 156, 61, 60, 53, 47
	};

	public DefaultTlsServer(TlsCrypto crypto)
		: base(crypto)
	{
	}

	protected virtual TlsCredentialedSigner GetDsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsCredentialedSigner GetECDsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsCredentialedDecryptor GetRsaEncryptionCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsCredentialedSigner GetRsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return TlsUtilities.GetSupportedCipherSuites(Crypto, DefaultCipherSuites);
	}

	public override TlsCredentials GetCredentials()
	{
		switch (m_context.SecurityParameters.KeyExchangeAlgorithm)
		{
		case 17:
			return GetECDsaSignerCredentials();
		case 11:
		case 20:
			return null;
		case 1:
			return GetRsaEncryptionCredentials();
		case 3:
			return GetDsaSignerCredentials();
		default:
			throw new TlsFatalAlert(80);
		case 5:
		case 19:
			return GetRsaSignerCredentials();
		}
	}
}
