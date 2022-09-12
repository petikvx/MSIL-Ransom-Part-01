using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls;

public abstract class DefaultTlsServer : AbstractTlsServer
{
	public DefaultTlsServer()
	{
	}

	public DefaultTlsServer(TlsCipherFactory cipherFactory)
		: base(cipherFactory)
	{
	}

	protected virtual TlsSignerCredentials GetDsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsSignerCredentials GetECDsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsEncryptionCredentials GetRsaEncryptionCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsSignerCredentials GetRsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual DHParameters GetDHParameters()
	{
		return DHStandardGroups.rfc5114_2048_256;
	}

	protected override int[] GetCipherSuites()
	{
		return new int[18]
		{
			49200, 49199, 49192, 49191, 49172, 49171, 159, 158, 107, 103,
			57, 51, 157, 156, 61, 60, 53, 47
		};
	}

	public override TlsCredentials GetCredentials()
	{
		switch (TlsUtilities.GetKeyExchangeAlgorithm(mSelectedCipherSuite))
		{
		case 16:
		case 17:
			return GetECDsaSignerCredentials();
		case 1:
			return GetRsaEncryptionCredentials();
		case 5:
		case 19:
			return GetRsaSignerCredentials();
		default:
			throw new TlsFatalAlert(80);
		case 3:
		case 7:
			return GetDsaSignerCredentials();
		}
	}

	public override TlsKeyExchange GetKeyExchange()
	{
		int keyExchangeAlgorithm = TlsUtilities.GetKeyExchangeAlgorithm(mSelectedCipherSuite);
		switch (keyExchangeAlgorithm)
		{
		case 16:
		case 18:
			return CreateECDHKeyExchange(keyExchangeAlgorithm);
		case 17:
		case 19:
			return CreateECDheKeyExchange(keyExchangeAlgorithm);
		case 1:
			return CreateRsaKeyExchange();
		case 3:
		case 5:
			return CreateDheKeyExchange(keyExchangeAlgorithm);
		default:
			throw new TlsFatalAlert(80);
		case 7:
		case 9:
			return CreateDHKeyExchange(keyExchangeAlgorithm);
		}
	}

	protected virtual TlsKeyExchange CreateDHKeyExchange(int keyExchange)
	{
		return new TlsDHKeyExchange(keyExchange, mSupportedSignatureAlgorithms, GetDHParameters());
	}

	protected virtual TlsKeyExchange CreateDheKeyExchange(int keyExchange)
	{
		return new TlsDheKeyExchange(keyExchange, mSupportedSignatureAlgorithms, GetDHParameters());
	}

	protected virtual TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
	{
		return new TlsECDHKeyExchange(keyExchange, mSupportedSignatureAlgorithms, mNamedCurves, mClientECPointFormats, mServerECPointFormats);
	}

	protected virtual TlsKeyExchange CreateECDheKeyExchange(int keyExchange)
	{
		return new TlsECDheKeyExchange(keyExchange, mSupportedSignatureAlgorithms, mNamedCurves, mClientECPointFormats, mServerECPointFormats);
	}

	protected virtual TlsKeyExchange CreateRsaKeyExchange()
	{
		return new TlsRsaKeyExchange(mSupportedSignatureAlgorithms);
	}
}
