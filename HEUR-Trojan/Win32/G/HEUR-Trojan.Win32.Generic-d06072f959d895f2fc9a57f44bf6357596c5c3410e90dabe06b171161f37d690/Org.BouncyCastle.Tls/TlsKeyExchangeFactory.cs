using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsKeyExchangeFactory
{
	TlsKeyExchange CreateDHKeyExchange(int keyExchange);

	TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier);

	TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig);

	TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, TlsDHGroupVerifier dhGroupVerifier);

	TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, TlsDHConfig dhConfig);

	TlsKeyExchange CreateECDHKeyExchange(int keyExchange);

	TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange);

	TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, TlsECConfig ecConfig);

	TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange);

	TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, TlsECConfig ecConfig);

	TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, TlsPskIdentity pskIdentity, TlsDHGroupVerifier dhGroupVerifier);

	TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, TlsPskIdentityManager pskIdentityManager, TlsDHConfig dhConfig, TlsECConfig ecConfig);

	TlsKeyExchange CreateRsaKeyExchange(int keyExchange);

	TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier);

	TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, TlsSrpLoginParameters loginParameters);
}
