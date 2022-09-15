using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsPeer
{
	TlsCrypto Crypto { get; }

	void NotifyCloseHandle(TlsCloseable closehandle);

	void Cancel();

	ProtocolVersion[] GetProtocolVersions();

	int[] GetCipherSuites();

	void NotifyHandshakeBeginning();

	int GetHandshakeTimeoutMillis();

	bool AllowLegacyResumption();

	int GetMaxCertificateChainLength();

	int GetMaxHandshakeMessageSize();

	short[] GetPskKeyExchangeModes();

	bool RequiresCloseNotify();

	bool RequiresExtendedMasterSecret();

	bool ShouldUseExtendedMasterSecret();

	bool ShouldUseExtendedPadding();

	bool ShouldUseGmtUnixTime();

	void NotifySecureRenegotiation(bool secureRenegotiation);

	TlsKeyExchangeFactory GetKeyExchangeFactory();

	void NotifyAlertRaised(short alertLevel, short alertDescription, string message, Exception cause);

	void NotifyAlertReceived(short alertLevel, short alertDescription);

	void NotifyHandshakeComplete();

	TlsHeartbeat GetHeartbeat();

	short GetHeartbeatPolicy();
}
