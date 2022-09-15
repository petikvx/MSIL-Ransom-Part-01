using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class SrpTlsServer : AbstractTlsServer
{
	private static readonly int[] DefaultCipherSuites = new int[6] { 49186, 49183, 49185, 49182, 49184, 49181 };

	protected readonly TlsSrpIdentityManager m_srpIdentityManager;

	protected byte[] m_srpIdentity;

	protected TlsSrpLoginParameters m_srpLoginParameters;

	public SrpTlsServer(TlsCrypto crypto, TlsSrpIdentityManager srpIdentityManager)
		: base(crypto)
	{
		m_srpIdentityManager = srpIdentityManager;
	}

	protected virtual TlsCredentialedSigner GetDsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual TlsCredentialedSigner GetRsaSignerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	protected override ProtocolVersion[] GetSupportedVersions()
	{
		return ProtocolVersion.TLSv12.DownTo(ProtocolVersion.TLSv10);
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return TlsUtilities.GetSupportedCipherSuites(Crypto, DefaultCipherSuites);
	}

	public override void ProcessClientExtensions(IDictionary clientExtensions)
	{
		base.ProcessClientExtensions(clientExtensions);
		m_srpIdentity = TlsSrpUtilities.GetSrpExtension(clientExtensions);
	}

	public override int GetSelectedCipherSuite()
	{
		int selectedCipherSuite = base.GetSelectedCipherSuite();
		if (TlsSrpUtilities.IsSrpCipherSuite(selectedCipherSuite))
		{
			if (m_srpIdentity != null)
			{
				m_srpLoginParameters = m_srpIdentityManager.GetLoginParameters(m_srpIdentity);
			}
			if (m_srpLoginParameters == null)
			{
				throw new TlsFatalAlert(115);
			}
		}
		return selectedCipherSuite;
	}

	public override TlsCredentials GetCredentials()
	{
		return m_context.SecurityParameters.KeyExchangeAlgorithm switch
		{
			21 => null, 
			22 => GetDsaSignerCredentials(), 
			23 => GetRsaSignerCredentials(), 
			_ => throw new TlsFatalAlert(80), 
		};
	}

	public override TlsSrpLoginParameters GetSrpLoginParameters()
	{
		return m_srpLoginParameters;
	}
}
