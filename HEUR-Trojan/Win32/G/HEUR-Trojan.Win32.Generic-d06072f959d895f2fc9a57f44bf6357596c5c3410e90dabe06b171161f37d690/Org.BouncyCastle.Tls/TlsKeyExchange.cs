using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsKeyExchange
{
	bool RequiresServerKeyExchange { get; }

	bool RequiresCertificateVerify { get; }

	void Init(TlsContext context);

	void SkipServerCredentials();

	void ProcessServerCredentials(TlsCredentials serverCredentials);

	void ProcessServerCertificate(Certificate serverCertificate);

	byte[] GenerateServerKeyExchange();

	void SkipServerKeyExchange();

	void ProcessServerKeyExchange(Stream input);

	short[] GetClientCertificateTypes();

	void SkipClientCredentials();

	void ProcessClientCredentials(TlsCredentials clientCredentials);

	void ProcessClientCertificate(Certificate clientCertificate);

	void GenerateClientKeyExchange(Stream output);

	void ProcessClientKeyExchange(Stream input);

	TlsSecret GeneratePreMasterSecret();
}
