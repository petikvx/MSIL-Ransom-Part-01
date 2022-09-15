using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public class TlsDheKeyExchange : AbstractTlsKeyExchange
{
	protected TlsDHGroupVerifier m_dhGroupVerifier;

	protected TlsDHConfig m_dhConfig;

	protected TlsCredentialedSigner m_serverCredentials;

	protected TlsCertificate m_serverCertificate;

	protected TlsAgreement m_agreement;

	public override bool RequiresServerKeyExchange => true;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 3 && keyExchange != 5)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsDheKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
		: this(keyExchange, dhGroupVerifier, null)
	{
	}

	public TlsDheKeyExchange(int keyExchange, TlsDHConfig dhConfig)
		: this(keyExchange, null, dhConfig)
	{
	}

	private TlsDheKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier, TlsDHConfig dhConfig)
		: base(CheckKeyExchange(keyExchange))
	{
		m_dhGroupVerifier = dhGroupVerifier;
		m_dhConfig = dhConfig;
	}

	public override void SkipServerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		m_serverCredentials = TlsUtilities.RequireSignerCredentials(serverCredentials);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		m_serverCertificate = serverCertificate.GetCertificateAt(0);
	}

	public override byte[] GenerateServerKeyExchange()
	{
		DigestInputBuffer digestInputBuffer = new DigestInputBuffer();
		TlsDHUtilities.WriteDHConfig(m_dhConfig, digestInputBuffer);
		m_agreement = m_context.Crypto.CreateDHDomain(m_dhConfig).CreateDH();
		TlsUtilities.WriteOpaque16(m_agreement.GenerateEphemeral(), digestInputBuffer);
		TlsUtilities.GenerateServerKeyExchangeSignature(m_context, m_serverCredentials, null, digestInputBuffer);
		return digestInputBuffer.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		DigestInputBuffer digestInputBuffer = new DigestInputBuffer();
		Stream input2 = new TeeInputStream(input, digestInputBuffer);
		m_dhConfig = TlsDHUtilities.ReceiveDHConfig(m_context, m_dhGroupVerifier, input2);
		byte[] peerValue = TlsUtilities.ReadOpaque16(input2, 1);
		TlsUtilities.VerifyServerKeyExchangeSignature(m_context, input, m_serverCertificate, null, digestInputBuffer);
		m_agreement = m_context.Crypto.CreateDHDomain(m_dhConfig).CreateDH();
		m_agreement.ReceivePeerValue(peerValue);
	}

	public override short[] GetClientCertificateTypes()
	{
		return new short[3] { 2, 64, 1 };
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		TlsUtilities.RequireSignerCredentials(clientCredentials);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		TlsUtilities.WriteOpaque16(m_agreement.GenerateEphemeral(), output);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		m_agreement.ReceivePeerValue(TlsUtilities.ReadOpaque16(input, 1));
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		return m_agreement.CalculateSecret();
	}
}
