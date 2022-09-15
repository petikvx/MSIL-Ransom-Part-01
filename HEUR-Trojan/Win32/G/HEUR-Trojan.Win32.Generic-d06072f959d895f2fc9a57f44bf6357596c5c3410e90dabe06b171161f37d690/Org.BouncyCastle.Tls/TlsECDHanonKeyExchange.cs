using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class TlsECDHanonKeyExchange : AbstractTlsKeyExchange
{
	protected TlsECConfig m_ecConfig;

	protected TlsAgreement m_agreement;

	public override bool RequiresServerKeyExchange => true;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 20)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsECDHanonKeyExchange(int keyExchange)
		: this(keyExchange, null)
	{
	}

	public TlsECDHanonKeyExchange(int keyExchange, TlsECConfig ecConfig)
		: base(CheckKeyExchange(keyExchange))
	{
		m_ecConfig = ecConfig;
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
		TlsEccUtilities.WriteECConfig(m_ecConfig, memoryStream);
		m_agreement = m_context.Crypto.CreateECDomain(m_ecConfig).CreateECDH();
		GenerateEphemeral(memoryStream);
		return memoryStream.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		m_ecConfig = TlsEccUtilities.ReceiveECDHConfig(m_context, input);
		byte[] point = TlsUtilities.ReadOpaque8(input, 1);
		m_agreement = m_context.Crypto.CreateECDomain(m_ecConfig).CreateECDH();
		ProcessEphemeral(point);
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
		GenerateEphemeral(output);
	}

	public override void ProcessClientCertificate(Certificate clientCertificate)
	{
		throw new TlsFatalAlert(10);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		byte[] point = TlsUtilities.ReadOpaque8(input, 1);
		ProcessEphemeral(point);
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		return m_agreement.CalculateSecret();
	}

	protected virtual void GenerateEphemeral(Stream output)
	{
		TlsUtilities.WriteOpaque8(m_agreement.GenerateEphemeral(), output);
	}

	protected virtual void ProcessEphemeral(byte[] point)
	{
		TlsEccUtilities.CheckPointEncoding(m_ecConfig.NamedGroup, point);
		m_agreement.ReceivePeerValue(point);
	}
}
