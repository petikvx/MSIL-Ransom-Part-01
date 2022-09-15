using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class TlsPskKeyExchange : AbstractTlsKeyExchange
{
	protected TlsPskIdentity m_pskIdentity;

	protected TlsPskIdentityManager m_pskIdentityManager;

	protected TlsDHGroupVerifier m_dhGroupVerifier;

	protected byte[] m_psk_identity_hint;

	protected byte[] m_psk;

	protected TlsDHConfig m_dhConfig;

	protected TlsECConfig m_ecConfig;

	protected TlsAgreement m_agreement;

	protected TlsCredentialedDecryptor m_serverCredentials;

	protected TlsEncryptor m_serverEncryptor;

	protected TlsSecret m_preMasterSecret;

	public override bool RequiresServerKeyExchange
	{
		get
		{
			int keyExchange = m_keyExchange;
			if (keyExchange != 14 && keyExchange != 24)
			{
				return false;
			}
			return true;
		}
	}

	private static int CheckKeyExchange(int keyExchange)
	{
		if ((uint)(keyExchange - 13) > 2u && keyExchange != 24)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsPskKeyExchange(int keyExchange, TlsPskIdentity pskIdentity, TlsDHGroupVerifier dhGroupVerifier)
		: this(keyExchange, pskIdentity, null, dhGroupVerifier, null, null)
	{
	}

	public TlsPskKeyExchange(int keyExchange, TlsPskIdentityManager pskIdentityManager, TlsDHConfig dhConfig, TlsECConfig ecConfig)
		: this(keyExchange, null, pskIdentityManager, null, dhConfig, ecConfig)
	{
	}

	private TlsPskKeyExchange(int keyExchange, TlsPskIdentity pskIdentity, TlsPskIdentityManager pskIdentityManager, TlsDHGroupVerifier dhGroupVerifier, TlsDHConfig dhConfig, TlsECConfig ecConfig)
		: base(CheckKeyExchange(keyExchange))
	{
		m_pskIdentity = pskIdentity;
		m_pskIdentityManager = pskIdentityManager;
		m_dhGroupVerifier = dhGroupVerifier;
		m_dhConfig = dhConfig;
		m_ecConfig = ecConfig;
	}

	public override void SkipServerCredentials()
	{
		if (m_keyExchange == 15)
		{
			throw new TlsFatalAlert(80);
		}
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		if (m_keyExchange != 15)
		{
			throw new TlsFatalAlert(80);
		}
		m_serverCredentials = TlsUtilities.RequireDecryptorCredentials(serverCredentials);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		if (m_keyExchange != 15)
		{
			throw new TlsFatalAlert(10);
		}
		m_serverEncryptor = serverCertificate.GetCertificateAt(0).CreateEncryptor(3);
	}

	public override byte[] GenerateServerKeyExchange()
	{
		m_psk_identity_hint = m_pskIdentityManager.GetHint();
		if (m_psk_identity_hint == null && !RequiresServerKeyExchange)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream();
		if (m_psk_identity_hint == null)
		{
			TlsUtilities.WriteOpaque16(TlsUtilities.EmptyBytes, memoryStream);
		}
		else
		{
			TlsUtilities.WriteOpaque16(m_psk_identity_hint, memoryStream);
		}
		if (m_keyExchange == 14)
		{
			if (m_dhConfig == null)
			{
				throw new TlsFatalAlert(80);
			}
			TlsDHUtilities.WriteDHConfig(m_dhConfig, memoryStream);
			m_agreement = m_context.Crypto.CreateDHDomain(m_dhConfig).CreateDH();
			GenerateEphemeralDH(memoryStream);
		}
		else if (m_keyExchange == 24)
		{
			if (m_ecConfig == null)
			{
				throw new TlsFatalAlert(80);
			}
			TlsEccUtilities.WriteECConfig(m_ecConfig, memoryStream);
			m_agreement = m_context.Crypto.CreateECDomain(m_ecConfig).CreateECDH();
			GenerateEphemeralECDH(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		m_psk_identity_hint = TlsUtilities.ReadOpaque16(input);
		if (m_keyExchange == 14)
		{
			m_dhConfig = TlsDHUtilities.ReceiveDHConfig(m_context, m_dhGroupVerifier, input);
			byte[] y = TlsUtilities.ReadOpaque16(input, 1);
			m_agreement = m_context.Crypto.CreateDHDomain(m_dhConfig).CreateDH();
			ProcessEphemeralDH(y);
		}
		else if (m_keyExchange == 24)
		{
			m_ecConfig = TlsEccUtilities.ReceiveECDHConfig(m_context, input);
			byte[] point = TlsUtilities.ReadOpaque8(input, 1);
			m_agreement = m_context.Crypto.CreateECDomain(m_ecConfig).CreateECDH();
			ProcessEphemeralECDH(point);
		}
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		throw new TlsFatalAlert(80);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		if (m_psk_identity_hint == null)
		{
			m_pskIdentity.SkipIdentityHint();
		}
		else
		{
			m_pskIdentity.NotifyIdentityHint(m_psk_identity_hint);
		}
		byte[] pskIdentity = m_pskIdentity.GetPskIdentity();
		if (pskIdentity == null)
		{
			throw new TlsFatalAlert(80);
		}
		m_psk = m_pskIdentity.GetPsk();
		if (m_psk == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.WriteOpaque16(pskIdentity, output);
		m_context.SecurityParameters.m_pskIdentity = Arrays.Clone(pskIdentity);
		if (m_keyExchange == 14)
		{
			GenerateEphemeralDH(output);
		}
		else if (m_keyExchange == 24)
		{
			GenerateEphemeralECDH(output);
		}
		else if (m_keyExchange == 15)
		{
			m_preMasterSecret = TlsUtilities.GenerateEncryptedPreMasterSecret(m_context, m_serverEncryptor, output);
		}
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		byte[] array = TlsUtilities.ReadOpaque16(input);
		m_psk = m_pskIdentityManager.GetPsk(array);
		if (m_psk == null)
		{
			throw new TlsFatalAlert(115);
		}
		m_context.SecurityParameters.m_pskIdentity = array;
		if (m_keyExchange == 14)
		{
			byte[] y = TlsUtilities.ReadOpaque16(input, 1);
			ProcessEphemeralDH(y);
		}
		else if (m_keyExchange == 24)
		{
			byte[] point = TlsUtilities.ReadOpaque8(input, 1);
			ProcessEphemeralECDH(point);
		}
		else if (m_keyExchange == 15)
		{
			byte[] ciphertext = TlsUtilities.ReadEncryptedPms(m_context, input);
			m_preMasterSecret = m_serverCredentials.Decrypt(new TlsCryptoParameters(m_context), ciphertext);
		}
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		byte[] array = GenerateOtherSecret(m_psk.Length);
		MemoryStream memoryStream = new MemoryStream(4 + array.Length + m_psk.Length);
		TlsUtilities.WriteOpaque16(array, memoryStream);
		TlsUtilities.WriteOpaque16(m_psk, memoryStream);
		Array.Clear(m_psk, 0, m_psk.Length);
		m_psk = null;
		return m_context.Crypto.CreateSecret(memoryStream.ToArray());
	}

	protected virtual void GenerateEphemeralDH(Stream output)
	{
		TlsUtilities.WriteOpaque16(m_agreement.GenerateEphemeral(), output);
	}

	protected virtual void GenerateEphemeralECDH(Stream output)
	{
		TlsUtilities.WriteOpaque8(m_agreement.GenerateEphemeral(), output);
	}

	protected virtual byte[] GenerateOtherSecret(int pskLength)
	{
		if (m_keyExchange == 13)
		{
			return new byte[pskLength];
		}
		if ((m_keyExchange == 14 || m_keyExchange == 24) && m_agreement != null)
		{
			return m_agreement.CalculateSecret().Extract();
		}
		if (m_keyExchange != 15 || m_preMasterSecret == null)
		{
			throw new TlsFatalAlert(80);
		}
		return m_preMasterSecret.Extract();
	}

	protected virtual void ProcessEphemeralDH(byte[] y)
	{
		m_agreement.ReceivePeerValue(y);
	}

	protected virtual void ProcessEphemeralECDH(byte[] point)
	{
		TlsEccUtilities.CheckPointEncoding(m_ecConfig.NamedGroup, point);
		m_agreement.ReceivePeerValue(point);
	}
}
