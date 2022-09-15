using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedDecryptor : TlsCredentialedDecryptor, TlsCredentials
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly Certificate m_certificate;

	protected readonly AsymmetricKeyParameter m_privateKey;

	public virtual Certificate Certificate => m_certificate;

	public BcDefaultTlsCredentialedDecryptor(BcTlsCrypto crypto, Certificate certificate, AsymmetricKeyParameter privateKey)
	{
		if (crypto == null)
		{
			throw new ArgumentNullException("crypto");
		}
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (certificate.IsEmpty)
		{
			throw new ArgumentException("cannot be empty", "certificate");
		}
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (!privateKey.IsPrivate)
		{
			throw new ArgumentException("must be private", "privateKey");
		}
		if (!(privateKey is RsaKeyParameters))
		{
			throw new ArgumentException("'privateKey' type not supported: " + Platform.GetTypeName(privateKey));
		}
		m_crypto = crypto;
		m_certificate = certificate;
		m_privateKey = privateKey;
	}

	public virtual TlsSecret Decrypt(TlsCryptoParameters cryptoParams, byte[] ciphertext)
	{
		return SafeDecryptPreMasterSecret(cryptoParams, (RsaKeyParameters)m_privateKey, ciphertext);
	}

	protected virtual TlsSecret SafeDecryptPreMasterSecret(TlsCryptoParameters cryptoParams, RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
	{
		SecureRandom secureRandom = m_crypto.SecureRandom;
		ProtocolVersion rsaPreMasterSecretVersion = cryptoParams.RsaPreMasterSecretVersion;
		bool flag = false;
		byte[] array = new byte[48];
		secureRandom.NextBytes(array);
		byte[] array2 = Arrays.Clone(array);
		try
		{
			Pkcs1Encoding pkcs1Encoding = new Pkcs1Encoding(new RsaBlindedEngine(), array);
			pkcs1Encoding.Init(forEncryption: false, new ParametersWithRandom(rsaServerPrivateKey, secureRandom));
			array2 = pkcs1Encoding.ProcessBlock(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
		}
		catch (Exception)
		{
		}
		if (!flag || TlsImplUtilities.IsTlsV11(rsaPreMasterSecretVersion))
		{
			int num = (rsaPreMasterSecretVersion.MajorVersion ^ (array2[0] & 0xFF)) | (rsaPreMasterSecretVersion.MinorVersion ^ (array2[1] & 0xFF));
			num = num - 1 >> 31;
			for (int i = 0; i < 48; i++)
			{
				array2[i] = (byte)((array2[i] & num) | (array[i] & ~num));
			}
		}
		return m_crypto.CreateSecret(array2);
	}
}
