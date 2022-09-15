using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class TlsECDHKeyExchange : AbstractTlsKeyExchange
{
	protected TlsCredentialedAgreement m_agreementCredentials;

	protected TlsCertificate m_ecdhPeerCertificate;

	public override bool RequiresCertificateVerify => false;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 16 && keyExchange != 18)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsECDHKeyExchange(int keyExchange)
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
		m_ecdhPeerCertificate = serverCertificate.GetCertificateAt(0).CheckUsageInRole(2);
	}

	public override short[] GetClientCertificateTypes()
	{
		return new short[2] { 66, 65 };
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
		m_ecdhPeerCertificate = clientCertificate.GetCertificateAt(0).CheckUsageInRole(2);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		return m_agreementCredentials.GenerateAgreement(m_ecdhPeerCertificate);
	}
}
