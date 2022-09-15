using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class SessionParameters
{
	public sealed class Builder
	{
		private int m_cipherSuite = -1;

		private Certificate m_localCertificate;

		private TlsSecret m_masterSecret;

		private ProtocolVersion m_negotiatedVersion;

		private Certificate m_peerCertificate;

		private byte[] m_pskIdentity;

		private byte[] m_srpIdentity;

		private byte[] m_encodedServerExtensions;

		private bool m_extendedMasterSecret;

		public SessionParameters Build()
		{
			Validate(m_cipherSuite >= 0, "cipherSuite");
			Validate(m_masterSecret != null, "masterSecret");
			return new SessionParameters(m_cipherSuite, m_localCertificate, m_masterSecret, m_negotiatedVersion, m_peerCertificate, m_pskIdentity, m_srpIdentity, m_encodedServerExtensions, m_extendedMasterSecret);
		}

		public Builder SetCipherSuite(int cipherSuite)
		{
			m_cipherSuite = cipherSuite;
			return this;
		}

		public Builder SetExtendedMasterSecret(bool extendedMasterSecret)
		{
			m_extendedMasterSecret = extendedMasterSecret;
			return this;
		}

		public Builder SetLocalCertificate(Certificate localCertificate)
		{
			m_localCertificate = localCertificate;
			return this;
		}

		public Builder SetMasterSecret(TlsSecret masterSecret)
		{
			m_masterSecret = masterSecret;
			return this;
		}

		public Builder SetNegotiatedVersion(ProtocolVersion negotiatedVersion)
		{
			m_negotiatedVersion = negotiatedVersion;
			return this;
		}

		public Builder SetPeerCertificate(Certificate peerCertificate)
		{
			m_peerCertificate = peerCertificate;
			return this;
		}

		public Builder SetPskIdentity(byte[] pskIdentity)
		{
			m_pskIdentity = pskIdentity;
			return this;
		}

		public Builder SetSrpIdentity(byte[] srpIdentity)
		{
			m_srpIdentity = srpIdentity;
			return this;
		}

		public Builder SetServerExtensions(IDictionary serverExtensions)
		{
			if (serverExtensions != null && serverExtensions.Count >= 1)
			{
				MemoryStream memoryStream = new MemoryStream();
				TlsProtocol.WriteExtensions(memoryStream, serverExtensions);
				m_encodedServerExtensions = memoryStream.ToArray();
			}
			else
			{
				m_encodedServerExtensions = null;
			}
			return this;
		}

		private void Validate(bool condition, string parameter)
		{
			if (!condition)
			{
				throw new InvalidOperationException("Required session parameter '" + parameter + "' not configured");
			}
		}
	}

	private readonly int m_cipherSuite;

	private readonly Certificate m_localCertificate;

	private readonly TlsSecret m_masterSecret;

	private readonly ProtocolVersion m_negotiatedVersion;

	private readonly Certificate m_peerCertificate;

	private readonly byte[] m_pskIdentity;

	private readonly byte[] m_srpIdentity;

	private readonly byte[] m_encodedServerExtensions;

	private readonly bool m_extendedMasterSecret;

	public int CipherSuite => m_cipherSuite;

	public bool IsExtendedMasterSecret => m_extendedMasterSecret;

	public Certificate LocalCertificate => m_localCertificate;

	public TlsSecret MasterSecret => m_masterSecret;

	public ProtocolVersion NegotiatedVersion => m_negotiatedVersion;

	public Certificate PeerCertificate => m_peerCertificate;

	public byte[] PskIdentity => m_pskIdentity;

	public byte[] SrpIdentity => m_srpIdentity;

	private SessionParameters(int cipherSuite, Certificate localCertificate, TlsSecret masterSecret, ProtocolVersion negotiatedVersion, Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions, bool extendedMasterSecret)
	{
		m_cipherSuite = cipherSuite;
		m_localCertificate = localCertificate;
		m_masterSecret = masterSecret;
		m_negotiatedVersion = negotiatedVersion;
		m_peerCertificate = peerCertificate;
		m_pskIdentity = Arrays.Clone(pskIdentity);
		m_srpIdentity = Arrays.Clone(srpIdentity);
		m_encodedServerExtensions = encodedServerExtensions;
		m_extendedMasterSecret = extendedMasterSecret;
	}

	public void Clear()
	{
		if (m_masterSecret != null)
		{
			m_masterSecret.Destroy();
		}
	}

	public SessionParameters Copy()
	{
		return new SessionParameters(m_cipherSuite, m_localCertificate, m_masterSecret, m_negotiatedVersion, m_peerCertificate, m_pskIdentity, m_srpIdentity, m_encodedServerExtensions, m_extendedMasterSecret);
	}

	public IDictionary ReadServerExtensions()
	{
		if (m_encodedServerExtensions == null)
		{
			return null;
		}
		return TlsProtocol.ReadExtensions(new MemoryStream(m_encodedServerExtensions, writable: false));
	}
}
