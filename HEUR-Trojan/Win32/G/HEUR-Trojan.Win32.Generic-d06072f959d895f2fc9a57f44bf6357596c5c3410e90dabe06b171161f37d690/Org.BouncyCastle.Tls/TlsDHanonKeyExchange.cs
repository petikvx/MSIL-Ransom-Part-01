using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class TlsDHanonKeyExchange : AbstractTlsKeyExchange
{
	protected TlsDHGroupVerifier m_dhGroupVerifier;

	protected TlsDHConfig m_dhConfig;

	protected TlsAgreement m_agreement;

	public override bool RequiresServerKeyExchange => true;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 11)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsDHanonKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier)
		: this(keyExchange, dhGroupVerifier, null)
	{
	}

	public TlsDHanonKeyExchange(int keyExchange, TlsDHConfig dhConfig)
		: this(keyExchange, null, dhConfig)
	{
	}

	private TlsDHanonKeyExchange(int keyExchange, TlsDHGroupVerifier dhGroupVerifier, TlsDHConfig dhConfig)
		: base(CheckKeyExchange(keyExchange))
	{
		m_dhGroupVerifier = dhGroupVerifier;
		m_dhConfig = dhConfig;
	}

	public override void SkipServerCredentials()
	{
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		throw new TlsFatalAlert(80);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		throw new TlsFatalAlert(10);
	}

	public override byte[] GenerateServerKeyExchange()
	{
		MemoryStream memoryStream = new MemoryStream();
		TlsDHUtilities.WriteDHConfig(m_dhConfig, memoryStream);
		m_agreement = m_context.Crypto.CreateDHDomain(m_dhConfig).CreateDH();
		TlsUtilities.WriteOpaque16(m_agreement.GenerateEphemeral(), memoryStream);
		return memoryStream.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		m_dhConfig = TlsDHUtilities.ReceiveDHConfig(m_context, m_dhGroupVerifier, input);
		byte[] peerValue = TlsUtilities.ReadOpaque16(input, 1);
		m_agreement = m_context.Crypto.CreateDHDomain(m_dhConfig).CreateDH();
		m_agreement.ReceivePeerValue(peerValue);
	}

	public override short[] GetClientCertificateTypes()
	{
		return null;
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		throw new TlsFatalAlert(80);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		TlsUtilities.WriteOpaque16(m_agreement.GenerateEphemeral(), output);
	}

	public override void ProcessClientCertificate(Certificate clientCertificate)
	{
		throw new TlsFatalAlert(10);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		byte[] peerValue = TlsUtilities.ReadOpaque16(input, 1);
		m_agreement.ReceivePeerValue(peerValue);
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		return m_agreement.CalculateSecret();
	}
}
