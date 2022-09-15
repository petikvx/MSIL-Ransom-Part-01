using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public abstract class AbstractTlsKeyExchangeFactory : TlsKeyExchangeFactory
{
	public virtual TlsKeyExchange CreateDHKeyExchange(int keyExchange)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, TlsECConfig ecConfig)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, TlsECConfig ecConfig)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, TlsPskIdentity pskIdentity, TlsDHGroupVerifier dhGroupVerifier)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, TlsPskIdentityManager pskIdentityManager, TlsDHConfig dhConfig, TlsECConfig ecConfig)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateRsaKeyExchange(int keyExchange)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, TlsSrpLoginParameters loginParameters)
	{
		throw new TlsFatalAlert(80);
	}
}
