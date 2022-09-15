using System;
using System.Threading;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

internal abstract class AbstractTlsContext : TlsContext
{
	private static long counter = Times.NanoTime();

	private readonly TlsCrypto m_crypto;

	private readonly int m_connectionEnd;

	private readonly TlsNonceGenerator m_nonceGenerator;

	private SecurityParameters m_securityParameters;

	private ProtocolVersion[] m_clientSupportedVersions;

	private ProtocolVersion m_clientVersion;

	private ProtocolVersion m_rsaPreMasterSecretVersion;

	private TlsSession m_session;

	private object m_userObject;

	private bool m_connected;

	internal bool IsConnected
	{
		get
		{
			lock (this)
			{
				return m_connected;
			}
		}
	}

	internal bool IsHandshaking
	{
		get
		{
			lock (this)
			{
				return !m_connected && m_securityParameters != null;
			}
		}
	}

	public TlsCrypto Crypto => m_crypto;

	public virtual TlsNonceGenerator NonceGenerator => m_nonceGenerator;

	public SecurityParameters SecurityParameters
	{
		get
		{
			lock (this)
			{
				return m_securityParameters;
			}
		}
	}

	public abstract bool IsServer { get; }

	public virtual ProtocolVersion[] ClientSupportedVersions => m_clientSupportedVersions;

	public virtual ProtocolVersion ClientVersion => m_clientVersion;

	public virtual ProtocolVersion RsaPreMasterSecretVersion => m_rsaPreMasterSecretVersion;

	public virtual ProtocolVersion ServerVersion => SecurityParameters.NegotiatedVersion;

	public virtual TlsSession ResumableSession
	{
		get
		{
			TlsSession session = Session;
			if (session != null && session.IsResumable)
			{
				return session;
			}
			return null;
		}
	}

	public virtual TlsSession Session => m_session;

	public virtual object UserObject
	{
		get
		{
			return m_userObject;
		}
		set
		{
			m_userObject = value;
		}
	}

	private static long NextCounterValue()
	{
		return Interlocked.Increment(ref counter);
	}

	private static TlsNonceGenerator CreateNonceGenerator(TlsCrypto crypto, int connectionEnd)
	{
		byte[] array = new byte[16];
		Pack.UInt64_To_BE((ulong)NextCounterValue(), array, 0);
		Pack.UInt64_To_BE((ulong)Times.NanoTime(), array, 8);
		array[0] &= 127;
		array[0] |= (byte)(connectionEnd << 7);
		return crypto.CreateNonceGenerator(array);
	}

	internal AbstractTlsContext(TlsCrypto crypto, int connectionEnd)
	{
		m_crypto = crypto;
		m_connectionEnd = connectionEnd;
		m_nonceGenerator = CreateNonceGenerator(crypto, connectionEnd);
	}

	internal void HandshakeBeginning(TlsPeer peer)
	{
		lock (this)
		{
			if (m_securityParameters != null)
			{
				throw new TlsFatalAlert(80, "Handshake already started");
			}
			m_securityParameters = new SecurityParameters();
			m_securityParameters.m_entity = m_connectionEnd;
		}
		peer.NotifyHandshakeBeginning();
	}

	internal void HandshakeComplete(TlsPeer peer, TlsSession session)
	{
		lock (this)
		{
			if (m_securityParameters == null)
			{
				throw new TlsFatalAlert(80);
			}
			m_session = session;
			m_connected = true;
		}
		peer.NotifyHandshakeComplete();
	}

	internal void SetClientSupportedVersions(ProtocolVersion[] clientSupportedVersions)
	{
		m_clientSupportedVersions = clientSupportedVersions;
	}

	internal void SetClientVersion(ProtocolVersion clientVersion)
	{
		m_clientVersion = clientVersion;
	}

	internal void SetRsaPreMasterSecretVersion(ProtocolVersion rsaPreMasterSecretVersion)
	{
		m_rsaPreMasterSecretVersion = rsaPreMasterSecretVersion;
	}

	public virtual byte[] ExportChannelBinding(int channelBinding)
	{
		if (!IsConnected)
		{
			throw new InvalidOperationException("Export of channel bindings unavailable before handshake completion");
		}
		SecurityParameters securityParameters = SecurityParameters;
		if (TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
		{
			return null;
		}
		switch (channelBinding)
		{
		case 0:
		{
			byte[] tlsServerEndPoint = securityParameters.TlsServerEndPoint;
			if (!TlsUtilities.IsNullOrEmpty(tlsServerEndPoint))
			{
				return Arrays.Clone(tlsServerEndPoint);
			}
			return null;
		}
		default:
			throw new NotSupportedException();
		case 1:
			return Arrays.Clone(securityParameters.TlsUnique);
		}
	}

	public virtual byte[] ExportEarlyKeyingMaterial(string asciiLabel, byte[] context, int length)
	{
		if (!IsConnected)
		{
			throw new InvalidOperationException("Export of early key material only available during handshake");
		}
		SecurityParameters securityParameters = SecurityParameters;
		return ExportKeyingMaterial13(CheckEarlyExportSecret(securityParameters.EarlyExporterMasterSecret), securityParameters.PrfCryptoHashAlgorithm, asciiLabel, context, length);
	}

	public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context, int length)
	{
		if (!IsConnected)
		{
			throw new InvalidOperationException("Export of key material unavailable before handshake completion");
		}
		SecurityParameters securityParameters = SecurityParameters;
		if (!securityParameters.IsExtendedMasterSecret)
		{
			throw new InvalidOperationException("Export of key material requires extended_master_secret");
		}
		if (TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
		{
			return ExportKeyingMaterial13(CheckExportSecret(securityParameters.ExporterMasterSecret), securityParameters.PrfCryptoHashAlgorithm, asciiLabel, context, length);
		}
		byte[] seed = TlsUtilities.CalculateExporterSeed(securityParameters, context);
		return TlsUtilities.Prf(securityParameters, CheckExportSecret(securityParameters.MasterSecret), asciiLabel, seed, length).Extract();
	}

	protected virtual byte[] ExportKeyingMaterial13(TlsSecret secret, int cryptoHashAlgorithm, string asciiLabel, byte[] context, int length)
	{
		if (context == null)
		{
			context = TlsUtilities.EmptyBytes;
		}
		else if (!TlsUtilities.IsValidUint16(context.Length))
		{
			throw new ArgumentException("must have length less than 2^16 (or be null)", "context");
		}
		return TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, asciiLabel, context, length).Extract();
	}

	protected virtual TlsSecret CheckEarlyExportSecret(TlsSecret secret)
	{
		if (secret == null)
		{
			throw new InvalidOperationException("Export of early key material not available for this handshake");
		}
		return secret;
	}

	protected virtual TlsSecret CheckExportSecret(TlsSecret secret)
	{
		if (secret == null)
		{
			throw new InvalidOperationException("Export of key material only available from NotifyHandshakeComplete()");
		}
		return secret;
	}
}
