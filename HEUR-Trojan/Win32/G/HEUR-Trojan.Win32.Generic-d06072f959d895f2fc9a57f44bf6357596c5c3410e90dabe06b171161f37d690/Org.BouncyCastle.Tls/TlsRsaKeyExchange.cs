using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public class TlsRsaKeyExchange : AbstractTlsKeyExchange
{
	protected TlsCredentialedDecryptor m_serverCredentials;

	protected TlsEncryptor m_serverEncryptor;

	protected TlsSecret m_preMasterSecret;

	private static int CheckKeyExchange(int keyExchange)
	{
		if (keyExchange != 1)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsRsaKeyExchange(int keyExchange)
		: base(CheckKeyExchange(keyExchange))
	{
	}

	public override void SkipServerCredentials()
	{
		throw new TlsFatalAlert(80);
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		m_serverCredentials = TlsUtilities.RequireDecryptorCredentials(serverCredentials);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		m_serverEncryptor = serverCertificate.GetCertificateAt(0).CreateEncryptor(3);
	}

	public override short[] GetClientCertificateTypes()
	{
		return new short[3] { 1, 2, 64 };
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		TlsUtilities.RequireSignerCredentials(clientCredentials);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		m_preMasterSecret = TlsUtilities.GenerateEncryptedPreMasterSecret(m_context, m_serverEncryptor, output);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		byte[] ciphertext = TlsUtilities.ReadEncryptedPms(m_context, input);
		m_preMasterSecret = m_serverCredentials.Decrypt(new TlsCryptoParameters(m_context), ciphertext);
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		TlsSecret preMasterSecret = m_preMasterSecret;
		m_preMasterSecret = null;
		return preMasterSecret;
	}
}
