using System.Collections;

namespace Org.BouncyCastle.Tls;

public interface TlsClient : TlsPeer
{
	void Init(TlsClientContext context);

	TlsSession GetSessionToResume();

	IList GetExternalPsks();

	bool IsFallback();

	IDictionary GetClientExtensions();

	IList GetEarlyKeyShareGroups();

	void NotifyServerVersion(ProtocolVersion selectedVersion);

	void NotifySessionToResume(TlsSession session);

	void NotifySessionID(byte[] sessionID);

	void NotifySelectedCipherSuite(int selectedCipherSuite);

	void NotifySelectedPsk(TlsPsk selectedPsk);

	void ProcessServerExtensions(IDictionary serverExtensions);

	void ProcessServerSupplementalData(IList serverSupplementalData);

	TlsPskIdentity GetPskIdentity();

	TlsSrpIdentity GetSrpIdentity();

	TlsDHGroupVerifier GetDHGroupVerifier();

	TlsSrpConfigVerifier GetSrpConfigVerifier();

	TlsAuthentication GetAuthentication();

	IList GetClientSupplementalData();

	void NotifyNewSessionTicket(NewSessionTicket newSessionTicket);
}
