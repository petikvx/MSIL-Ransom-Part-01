using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class SrpTlsClient : AbstractTlsClient
{
	private static readonly int[] DefaultCipherSuites = new int[1] { 49182 };

	protected readonly TlsSrpIdentity m_srpIdentity;

	protected virtual bool RequireSrpServerExtension => false;

	public SrpTlsClient(TlsCrypto crypto, byte[] identity, byte[] password)
		: this(crypto, new BasicTlsSrpIdentity(identity, password))
	{
	}

	public SrpTlsClient(TlsCrypto crypto, TlsSrpIdentity srpIdentity)
		: base(crypto)
	{
		m_srpIdentity = srpIdentity;
	}

	protected override int[] GetSupportedCipherSuites()
	{
		return TlsUtilities.GetSupportedCipherSuites(Crypto, DefaultCipherSuites);
	}

	protected override ProtocolVersion[] GetSupportedVersions()
	{
		return ProtocolVersion.TLSv12.DownTo(ProtocolVersion.TLSv10);
	}

	public override IDictionary GetClientExtensions()
	{
		IDictionary dictionary = TlsExtensionsUtilities.EnsureExtensionsInitialised(base.GetClientExtensions());
		TlsSrpUtilities.AddSrpExtension(dictionary, m_srpIdentity.GetSrpIdentity());
		return dictionary;
	}

	public override void ProcessServerExtensions(IDictionary serverExtensions)
	{
		if (!TlsUtilities.HasExpectedEmptyExtensionData(serverExtensions, 12, 47) && RequireSrpServerExtension)
		{
			throw new TlsFatalAlert(47);
		}
		base.ProcessServerExtensions(serverExtensions);
	}

	public override TlsSrpIdentity GetSrpIdentity()
	{
		return m_srpIdentity;
	}

	public override TlsAuthentication GetAuthentication()
	{
		throw new TlsFatalAlert(80);
	}
}
