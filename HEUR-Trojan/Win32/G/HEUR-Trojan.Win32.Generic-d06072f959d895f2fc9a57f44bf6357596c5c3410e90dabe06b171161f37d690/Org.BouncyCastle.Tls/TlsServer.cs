using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsServer : TlsPeer
{
	void Init(TlsServerContext context);

	TlsSession GetSessionToResume(byte[] sessionID);

	byte[] GetNewSessionID();

	void NotifySession(TlsSession session);

	void NotifyClientVersion(ProtocolVersion clientVersion);

	void NotifyFallback(bool isFallback);

	void NotifyOfferedCipherSuites(int[] offeredCipherSuites);

	void ProcessClientExtensions(IDictionary clientExtensions);

	ProtocolVersion GetServerVersion();

	int[] GetSupportedGroups();

	int GetSelectedCipherSuite();

	IDictionary GetServerExtensions();

	void GetServerExtensionsForConnection(IDictionary serverExtensions);

	IList GetServerSupplementalData();

	TlsCredentials GetCredentials();

	CertificateStatus GetCertificateStatus();

	CertificateRequest GetCertificateRequest();

	TlsPskIdentityManager GetPskIdentityManager();

	TlsSrpLoginParameters GetSrpLoginParameters();

	TlsDHConfig GetDHConfig();

	TlsECConfig GetECDHConfig();

	void ProcessClientSupplementalData(IList clientSupplementalData);

	void NotifyClientCertificate(Certificate clientCertificate);

	NewSessionTicket GetNewSessionTicket();
}
