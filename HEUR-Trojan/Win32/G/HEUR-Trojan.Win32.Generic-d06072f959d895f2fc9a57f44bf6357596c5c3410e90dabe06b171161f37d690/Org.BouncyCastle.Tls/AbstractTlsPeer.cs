using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public abstract class AbstractTlsPeer : TlsPeer
{
	private readonly TlsCrypto m_crypto;

	private volatile TlsCloseable m_closeHandle;

	public virtual TlsCrypto Crypto => m_crypto;

	protected AbstractTlsPeer(TlsCrypto crypto)
	{
		m_crypto = crypto;
	}

	protected virtual ProtocolVersion[] GetSupportedVersions()
	{
		return ProtocolVersion.TLSv12.DownTo(ProtocolVersion.TLSv10);
	}

	protected abstract int[] GetSupportedCipherSuites();

	public virtual void Cancel()
	{
		m_closeHandle?.Close();
	}

	public virtual void NotifyCloseHandle(TlsCloseable closeHandle)
	{
		m_closeHandle = closeHandle;
	}

	public abstract ProtocolVersion[] GetProtocolVersions();

	public abstract int[] GetCipherSuites();

	public virtual void NotifyHandshakeBeginning()
	{
	}

	public virtual int GetHandshakeTimeoutMillis()
	{
		return 0;
	}

	public virtual bool AllowLegacyResumption()
	{
		return false;
	}

	public virtual int GetMaxCertificateChainLength()
	{
		return 10;
	}

	public virtual int GetMaxHandshakeMessageSize()
	{
		return 32768;
	}

	public virtual short[] GetPskKeyExchangeModes()
	{
		return new short[1] { 1 };
	}

	public virtual bool RequiresCloseNotify()
	{
		return true;
	}

	public virtual bool RequiresExtendedMasterSecret()
	{
		return false;
	}

	public virtual bool ShouldCheckSigAlgOfPeerCerts()
	{
		return true;
	}

	public virtual bool ShouldUseExtendedMasterSecret()
	{
		return true;
	}

	public virtual bool ShouldUseExtendedPadding()
	{
		return false;
	}

	public virtual bool ShouldUseGmtUnixTime()
	{
		return false;
	}

	public virtual void NotifySecureRenegotiation(bool secureRenegotiation)
	{
		if (!secureRenegotiation)
		{
			throw new TlsFatalAlert(40);
		}
	}

	public virtual TlsKeyExchangeFactory GetKeyExchangeFactory()
	{
		return new DefaultTlsKeyExchangeFactory();
	}

	public virtual void NotifyAlertRaised(short alertLevel, short alertDescription, string message, Exception cause)
	{
	}

	public virtual void NotifyAlertReceived(short alertLevel, short alertDescription)
	{
	}

	public virtual void NotifyHandshakeComplete()
	{
	}

	public virtual TlsHeartbeat GetHeartbeat()
	{
		return null;
	}

	public virtual short GetHeartbeatPolicy()
	{
		return 2;
	}
}
