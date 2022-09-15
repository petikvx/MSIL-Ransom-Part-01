using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public abstract class DefaultTlsClient : AbstractTlsClient
{
	private static readonly int[] DefaultCipherSuites = new int[15]
	{
		52393, 49195, 49187, 49161, 52392, 49199, 49191, 49171, 52394, 158,
		103, 51, 156, 60, 47
	};

	public DefaultTlsClient(TlsCrypto crypto)
		: base(crypto)
	{
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return TlsUtilities.GetSupportedCipherSuites(Crypto, DefaultCipherSuites);
	}
}
