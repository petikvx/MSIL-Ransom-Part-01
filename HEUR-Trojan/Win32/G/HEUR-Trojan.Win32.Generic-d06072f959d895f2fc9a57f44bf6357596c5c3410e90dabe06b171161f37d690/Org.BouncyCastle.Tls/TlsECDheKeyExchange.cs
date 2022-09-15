using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public class TlsECDheKeyExchange : AbstractTlsKeyExchange
{
	protected TlsECConfig m_ecConfig;

	protected TlsCredentialedSigner m_serverCredentials;

	protected TlsCertificate m_serverCertificate;

	protected TlsAgreement m_agreement;

	public override bool RequiresServerKeyExchange => true;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 17 && keyExchange != 19)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsECDheKeyExchange(int keyExchange)
		: this(keyExchange, null)
	{
	}

	public TlsECDheKeyExchange(int keyExchange, TlsECConfig ecConfig)
		: base(CheckKeyExchange(keyExchange))
	{
		m_ecConfig = ecConfig;
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
		TlsEccUtilities.WriteECConfig(m_ecConfig, digestInputBuffer);
		m_agreement = m_context.Crypto.CreateECDomain(m_ecConfig).CreateECDH();
		GenerateEphemeral(digestInputBuffer);
		TlsUtilities.GenerateServerKeyExchangeSignature(m_context, m_serverCredentials, null, digestInputBuffer);
		return digestInputBuffer.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		DigestInputBuffer digestInputBuffer = new DigestInputBuffer();
		Stream input2 = new TeeInputStream(input, digestInputBuffer);
		m_ecConfig = TlsEccUtilities.ReceiveECDHConfig(m_context, input2);
		byte[] point = TlsUtilities.ReadOpaque8(input2, 1);
		TlsUtilities.VerifyServerKeyExchangeSignature(m_context, input, m_serverCertificate, null, digestInputBuffer);
		m_agreement = m_context.Crypto.CreateECDomain(m_ecConfig).CreateECDH();
		ProcessEphemeral(point);
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
		GenerateEphemeral(output);
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
