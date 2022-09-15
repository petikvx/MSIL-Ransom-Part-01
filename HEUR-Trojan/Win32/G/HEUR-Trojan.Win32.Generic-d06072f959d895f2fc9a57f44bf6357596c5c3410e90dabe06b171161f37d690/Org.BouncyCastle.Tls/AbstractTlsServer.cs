using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class AbstractTlsServer : AbstractTlsPeer, TlsPeer, TlsServer
{
	protected TlsServerContext m_context;

	protected ProtocolVersion[] m_protocolVersions;

	protected int[] m_cipherSuites;

	protected int[] m_offeredCipherSuites;

	protected IDictionary m_clientExtensions;

	protected bool m_encryptThenMACOffered;

	protected short m_maxFragmentLengthOffered;

	protected bool m_truncatedHMacOffered;

	protected bool m_clientSentECPointFormats;

	protected CertificateStatusRequest m_certificateStatusRequest;

	protected IList m_statusRequestV2;

	protected IList m_trustedCAKeys;

	protected int m_selectedCipherSuite;

	protected IList m_clientProtocolNames;

	protected ProtocolName m_selectedProtocolName;

	protected readonly IDictionary m_serverExtensions = Platform.CreateHashtable();

	public AbstractTlsServer(TlsCrypto crypto)
		: base(crypto)
	{
	}

	protected virtual bool AllowCertificateStatus()
	{
		return true;
	}

	protected virtual bool AllowEncryptThenMac()
	{
		return true;
	}

	protected virtual bool AllowMultiCertStatus()
	{
		return false;
	}

	protected virtual bool AllowTruncatedHmac()
	{
		return false;
	}

	protected virtual bool AllowTrustedCAIndication()
	{
		return false;
	}

	protected virtual int GetMaximumNegotiableCurveBits()
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return NamedGroup.GetMaximumCurveBits();
		}
		int num = 0;
		for (int i = 0; i < clientSupportedGroups.Length; i++)
		{
			num = System.Math.Max(num, NamedGroup.GetCurveBits(clientSupportedGroups[i]));
		}
		return num;
	}

	protected virtual int GetMaximumNegotiableFiniteFieldBits()
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return NamedGroup.GetMaximumFiniteFieldBits();
		}
		int num = 0;
		for (int i = 0; i < clientSupportedGroups.Length; i++)
		{
			num = System.Math.Max(num, NamedGroup.GetFiniteFieldBits(clientSupportedGroups[i]));
		}
		return num;
	}

	protected virtual IList GetProtocolNames()
	{
		return null;
	}

	protected virtual bool IsSelectableCipherSuite(int cipherSuite, int availCurveBits, int availFiniteFieldBits, IList sigAlgs)
	{
		if (TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, m_context.ServerVersion) && availCurveBits >= TlsEccUtilities.GetMinimumCurveBits(cipherSuite) && availFiniteFieldBits >= TlsDHUtilities.GetMinimumFiniteFieldBits(cipherSuite))
		{
			return TlsUtilities.IsValidCipherSuiteForSignatureAlgorithms(cipherSuite, sigAlgs);
		}
		return false;
	}

	protected virtual bool PreferLocalCipherSuites()
	{
		return false;
	}

	protected virtual bool SelectCipherSuite(int cipherSuite)
	{
		m_selectedCipherSuite = cipherSuite;
		return true;
	}

	protected virtual int SelectDH(int minimumFiniteFieldBits)
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return SelectDHDefault(minimumFiniteFieldBits);
		}
		int num = 0;
		int num2;
		while (true)
		{
			if (num < clientSupportedGroups.Length)
			{
				num2 = clientSupportedGroups[num];
				if (NamedGroup.GetFiniteFieldBits(num2) >= minimumFiniteFieldBits)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num2;
	}

	protected virtual int SelectDHDefault(int minimumFiniteFieldBits)
	{
		if (minimumFiniteFieldBits > 2048)
		{
			if (minimumFiniteFieldBits > 3072)
			{
				if (minimumFiniteFieldBits > 4096)
				{
					if (minimumFiniteFieldBits > 6144)
					{
						if (minimumFiniteFieldBits > 8192)
						{
							return -1;
						}
						return 260;
					}
					return 259;
				}
				return 258;
			}
			return 257;
		}
		return 256;
	}

	protected virtual int SelectECDH(int minimumCurveBits)
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return SelectECDHDefault(minimumCurveBits);
		}
		int num = 0;
		int num2;
		while (true)
		{
			if (num < clientSupportedGroups.Length)
			{
				num2 = clientSupportedGroups[num];
				if (NamedGroup.GetCurveBits(num2) >= minimumCurveBits)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num2;
	}

	protected virtual int SelectECDHDefault(int minimumCurveBits)
	{
		if (minimumCurveBits > 256)
		{
			if (minimumCurveBits > 384)
			{
				if (minimumCurveBits > 521)
				{
					return -1;
				}
				return 25;
			}
			return 24;
		}
		return 23;
	}

	protected virtual ProtocolName SelectProtocolName()
	{
		IList protocolNames = GetProtocolNames();
		if (protocolNames != null && protocolNames.Count >= 1)
		{
			ProtocolName protocolName = SelectProtocolName(m_clientProtocolNames, protocolNames);
			if (protocolName == null)
			{
				throw new TlsFatalAlert(120);
			}
			return protocolName;
		}
		return null;
	}

	protected virtual ProtocolName SelectProtocolName(IList clientProtocolNames, IList serverProtocolNames)
	{
		foreach (ProtocolName serverProtocolName in serverProtocolNames)
		{
			if (clientProtocolNames.Contains(serverProtocolName))
			{
				return serverProtocolName;
			}
		}
		return null;
	}

	protected virtual bool ShouldSelectProtocolNameEarly()
	{
		return true;
	}

	public virtual void Init(TlsServerContext context)
	{
		m_context = context;
		m_protocolVersions = GetSupportedVersions();
		m_cipherSuites = GetSupportedCipherSuites();
	}

	public override ProtocolVersion[] GetProtocolVersions()
	{
		return m_protocolVersions;
	}

	public override int[] GetCipherSuites()
	{
		return m_cipherSuites;
	}

	public override void NotifyHandshakeBeginning()
	{
		base.NotifyHandshakeBeginning();
		m_offeredCipherSuites = null;
		m_clientExtensions = null;
		m_encryptThenMACOffered = false;
		m_maxFragmentLengthOffered = 0;
		m_truncatedHMacOffered = false;
		m_clientSentECPointFormats = false;
		m_certificateStatusRequest = null;
		m_selectedCipherSuite = -1;
		m_selectedProtocolName = null;
		m_serverExtensions.Clear();
	}

	public virtual TlsSession GetSessionToResume(byte[] sessionID)
	{
		return null;
	}

	public virtual byte[] GetNewSessionID()
	{
		return null;
	}

	public virtual void NotifySession(TlsSession session)
	{
	}

	public virtual void NotifyClientVersion(ProtocolVersion clientVersion)
	{
	}

	public virtual void NotifyFallback(bool isFallback)
	{
		if (!isFallback)
		{
			return;
		}
		ProtocolVersion[] protocolVersions = GetProtocolVersions();
		ProtocolVersion clientVersion = m_context.ClientVersion;
		ProtocolVersion protocolVersion;
		if (clientVersion.IsTls)
		{
			protocolVersion = ProtocolVersion.GetLatestTls(protocolVersions);
		}
		else
		{
			if (!clientVersion.IsDtls)
			{
				throw new TlsFatalAlert(80);
			}
			protocolVersion = ProtocolVersion.GetLatestDtls(protocolVersions);
		}
		if (protocolVersion != null && protocolVersion.IsLaterVersionOf(clientVersion))
		{
			throw new TlsFatalAlert(86);
		}
	}

	public virtual void NotifyOfferedCipherSuites(int[] offeredCipherSuites)
	{
		m_offeredCipherSuites = offeredCipherSuites;
	}

	public virtual void ProcessClientExtensions(IDictionary clientExtensions)
	{
		m_clientExtensions = clientExtensions;
		if (clientExtensions != null)
		{
			m_clientProtocolNames = TlsExtensionsUtilities.GetAlpnExtensionClient(clientExtensions);
			if (ShouldSelectProtocolNameEarly() && m_clientProtocolNames != null && m_clientProtocolNames.Count > 0)
			{
				m_selectedProtocolName = SelectProtocolName();
			}
			m_encryptThenMACOffered = TlsExtensionsUtilities.HasEncryptThenMacExtension(clientExtensions);
			m_truncatedHMacOffered = TlsExtensionsUtilities.HasTruncatedHmacExtension(clientExtensions);
			m_statusRequestV2 = TlsExtensionsUtilities.GetStatusRequestV2Extension(clientExtensions);
			m_trustedCAKeys = TlsExtensionsUtilities.GetTrustedCAKeysExtensionClient(clientExtensions);
			m_clientSentECPointFormats = TlsExtensionsUtilities.GetSupportedPointFormatsExtension(clientExtensions) != null;
			m_certificateStatusRequest = TlsExtensionsUtilities.GetStatusRequestExtension(clientExtensions);
			m_maxFragmentLengthOffered = TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions);
			if (m_maxFragmentLengthOffered >= 0 && !MaxFragmentLength.IsValid(m_maxFragmentLengthOffered))
			{
				throw new TlsFatalAlert(47);
			}
		}
	}

	public virtual ProtocolVersion GetServerVersion()
	{
		ProtocolVersion[] protocolVersions = GetProtocolVersions();
		ProtocolVersion[] clientSupportedVersions = m_context.ClientSupportedVersions;
		int num = 0;
		ProtocolVersion protocolVersion;
		while (true)
		{
			if (num < clientSupportedVersions.Length)
			{
				protocolVersion = clientSupportedVersions[num];
				if (ProtocolVersion.Contains(protocolVersions, protocolVersion))
				{
					break;
				}
				num++;
				continue;
			}
			throw new TlsFatalAlert(70);
		}
		return protocolVersion;
	}

	public virtual int[] GetSupportedGroups()
	{
		return new int[7] { 29, 30, 23, 24, 256, 257, 258 };
	}

	public virtual int GetSelectedCipherSuite()
	{
		SecurityParameters securityParameters = m_context.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (TlsUtilities.IsTlsV13(negotiatedVersion))
		{
			int commonCipherSuite = TlsUtilities.GetCommonCipherSuite13(negotiatedVersion, m_offeredCipherSuites, GetCipherSuites(), PreferLocalCipherSuites());
			if (commonCipherSuite >= 0 && SelectCipherSuite(commonCipherSuite))
			{
				return commonCipherSuite;
			}
		}
		else
		{
			IList usableSignatureAlgorithms = TlsUtilities.GetUsableSignatureAlgorithms(securityParameters.ClientSigAlgs);
			int maximumNegotiableCurveBits = GetMaximumNegotiableCurveBits();
			int maximumNegotiableFiniteFieldBits = GetMaximumNegotiableFiniteFieldBits();
			int[] commonCipherSuites = TlsUtilities.GetCommonCipherSuites(m_offeredCipherSuites, GetCipherSuites(), PreferLocalCipherSuites());
			foreach (int num in commonCipherSuites)
			{
				if (IsSelectableCipherSuite(num, maximumNegotiableCurveBits, maximumNegotiableFiniteFieldBits, usableSignatureAlgorithms) && SelectCipherSuite(num))
				{
					return num;
				}
			}
		}
		throw new TlsFatalAlert(40, "No selectable cipher suite");
	}

	public virtual IDictionary GetServerExtensions()
	{
		if (TlsUtilities.IsTlsV13(m_context))
		{
			if (m_certificateStatusRequest != null && !AllowCertificateStatus())
			{
			}
		}
		else
		{
			if (m_encryptThenMACOffered && AllowEncryptThenMac() && TlsUtilities.IsBlockCipherSuite(m_selectedCipherSuite))
			{
				TlsExtensionsUtilities.AddEncryptThenMacExtension(m_serverExtensions);
			}
			if (m_truncatedHMacOffered && AllowTruncatedHmac())
			{
				TlsExtensionsUtilities.AddTruncatedHmacExtension(m_serverExtensions);
			}
			if (m_clientSentECPointFormats && TlsEccUtilities.IsEccCipherSuite(m_selectedCipherSuite))
			{
				TlsExtensionsUtilities.AddSupportedPointFormatsExtension(m_serverExtensions, new short[1]);
			}
			if (m_statusRequestV2 != null && AllowMultiCertStatus())
			{
				TlsExtensionsUtilities.AddEmptyExtensionData(m_serverExtensions, 17);
			}
			else if (m_certificateStatusRequest != null && AllowCertificateStatus())
			{
				TlsExtensionsUtilities.AddEmptyExtensionData(m_serverExtensions, 5);
			}
			if (m_trustedCAKeys != null && AllowTrustedCAIndication())
			{
				TlsExtensionsUtilities.AddTrustedCAKeysExtensionServer(m_serverExtensions);
			}
		}
		if (m_maxFragmentLengthOffered >= 0 && MaxFragmentLength.IsValid(m_maxFragmentLengthOffered))
		{
			TlsExtensionsUtilities.AddMaxFragmentLengthExtension(m_serverExtensions, m_maxFragmentLengthOffered);
		}
		return m_serverExtensions;
	}

	public virtual void GetServerExtensionsForConnection(IDictionary serverExtensions)
	{
		if (!ShouldSelectProtocolNameEarly() && m_clientProtocolNames != null && m_clientProtocolNames.Count > 0)
		{
			m_selectedProtocolName = SelectProtocolName();
		}
		if (m_selectedProtocolName == null)
		{
			serverExtensions.Remove(16);
		}
		else
		{
			TlsExtensionsUtilities.AddAlpnExtensionServer(serverExtensions, m_selectedProtocolName);
		}
	}

	public virtual IList GetServerSupplementalData()
	{
		return null;
	}

	public abstract TlsCredentials GetCredentials();

	public virtual CertificateStatus GetCertificateStatus()
	{
		return null;
	}

	public virtual CertificateRequest GetCertificateRequest()
	{
		return null;
	}

	public virtual TlsPskIdentityManager GetPskIdentityManager()
	{
		return null;
	}

	public virtual TlsSrpLoginParameters GetSrpLoginParameters()
	{
		return null;
	}

	public virtual TlsDHConfig GetDHConfig()
	{
		int minimumFiniteFieldBits = TlsDHUtilities.GetMinimumFiniteFieldBits(m_selectedCipherSuite);
		int namedGroup = SelectDH(minimumFiniteFieldBits);
		return TlsDHUtilities.CreateNamedDHConfig(m_context, namedGroup);
	}

	public virtual TlsECConfig GetECDHConfig()
	{
		int minimumCurveBits = TlsEccUtilities.GetMinimumCurveBits(m_selectedCipherSuite);
		int namedGroup = SelectECDH(minimumCurveBits);
		return TlsEccUtilities.CreateNamedECConfig(m_context, namedGroup);
	}

	public virtual void ProcessClientSupplementalData(IList clientSupplementalData)
	{
		if (clientSupplementalData != null)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual NewSessionTicket GetNewSessionTicket()
	{
		return new NewSessionTicket(0L, TlsUtilities.EmptyBytes);
	}
}
