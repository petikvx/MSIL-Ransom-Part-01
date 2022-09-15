using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class PskTlsClient : AbstractTlsClient
{
	private static readonly int[] DefaultCipherSuites = new int[7] { 52396, 49207, 49205, 52397, 170, 178, 144 };

	protected readonly TlsPskIdentity m_pskIdentity;

	public PskTlsClient(TlsCrypto crypto, byte[] identity, byte[] psk)
		: this(crypto, new BasicTlsPskIdentity(identity, psk))
	{
	}

	public PskTlsClient(TlsCrypto crypto, TlsPskIdentity pskIdentity)
		: base(crypto)
	{
		m_pskIdentity = pskIdentity;
	}

	protected override ProtocolVersion[] GetSupportedVersions()
	{
		return ProtocolVersion.TLSv12.DownTo(ProtocolVersion.TLSv10);
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return TlsUtilities.GetSupportedCipherSuites(Crypto, DefaultCipherSuites);
	}

	public override TlsPskIdentity GetPskIdentity()
	{
		return m_pskIdentity;
	}

	public override TlsAuthentication GetAuthentication()
	{
		throw new TlsFatalAlert(80);
	}
}
