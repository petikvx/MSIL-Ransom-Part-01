using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls;

public class PskTlsServer : AbstractTlsServer
{
	protected TlsPskIdentityManager mPskIdentityManager;

	public PskTlsServer(TlsPskIdentityManager pskIdentityManager)
		: this(new DefaultTlsCipherFactory(), pskIdentityManager)
	{
	}

	public PskTlsServer(TlsCipherFactory cipherFactory, TlsPskIdentityManager pskIdentityManager)
		: base(cipherFactory)
	{
		mPskIdentityManager = pskIdentityManager;
	}

	protected virtual TlsEncryptionCredentials GetRsaEncryptionCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual DHParameters GetDHParameters()
	{
		return DHStandardGroups.rfc7919_ffdhe2048;
	}

	protected override int[] GetCipherSuites()
	{
		return new int[4] { 49207, 49205, 178, 144 };
	}

	public override TlsCredentials GetCredentials()
	{
		switch (TlsUtilities.GetKeyExchangeAlgorithm(mSelectedCipherSuite))
		{
		default:
			throw new TlsFatalAlert(80);
		case 15:
			return GetRsaEncryptionCredentials();
		case 13:
		case 14:
		case 24:
			return null;
		}
	}

	public override TlsKeyExchange GetKeyExchange()
	{
		int keyExchangeAlgorithm = TlsUtilities.GetKeyExchangeAlgorithm(mSelectedCipherSuite);
		if ((uint)(keyExchangeAlgorithm - 13) > 2u && keyExchangeAlgorithm != 24)
		{
			throw new TlsFatalAlert(80);
		}
		return CreatePskKeyExchange(keyExchangeAlgorithm);
	}

	protected virtual TlsKeyExchange CreatePskKeyExchange(int keyExchange)
	{
		return new TlsPskKeyExchange(keyExchange, mSupportedSignatureAlgorithms, null, mPskIdentityManager, null, GetDHParameters(), mNamedCurves, mClientECPointFormats, mServerECPointFormats);
	}
}
