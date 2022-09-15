using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class TlsDHKeyExchange : AbstractTlsKeyExchange
{
	protected TlsCredentialedAgreement m_agreementCredentials;

	protected TlsCertificate m_dhPeerCertificate;

	public override bool RequiresCertificateVerify => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 7 && keyExchange != 9)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsDHKeyExchange(int keyExchange)
		: base(CheckKeyExchange(keyExchange))
	{
	}

	public override void SkipServerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		m_agreementCredentials = TlsUtilities.RequireAgreementCredentials(serverCredentials);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		m_dhPeerCertificate = serverCertificate.GetCertificateAt(0).CheckUsageInRole(1);
	}

	public override short[] GetClientCertificateTypes()
	{
		return new short[2] { 4, 3 };
	}

	public override void SkipClientCredentials()
	{
		throw new TlsFatalAlert(10);
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		m_agreementCredentials = TlsUtilities.RequireAgreementCredentials(clientCredentials);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
	}

	public override void ProcessClientCertificate(Certificate clientCertificate)
	{
		m_dhPeerCertificate = clientCertificate.GetCertificateAt(0).CheckUsageInRole(1);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		return m_agreementCredentials.GenerateAgreement(m_dhPeerCertificate);
	}
}
