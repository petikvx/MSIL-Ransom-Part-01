using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsCrypto : AbstractTlsCrypto
{
	private readonly SecureRandom m_entropySource;

	public override SecureRandom SecureRandom => m_entropySource;

	public BcTlsCrypto(SecureRandom entropySource)
	{
		m_entropySource = entropySource;
	}

	internal virtual BcTlsSecret AdoptLocalSecret(byte[] data)
	{
		return new BcTlsSecret(this, data);
	}

	public override TlsCertificate CreateCertificate(byte[] encoding)
	{
		return new BcTlsCertificate(this, encoding);
	}

	public override TlsCipher CreateCipher(TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int macAlgorithm)
	{
		switch (encryptionAlgorithm)
		{
		case 0:
			return CreateNullCipher(cryptoParams, macAlgorithm);
		default:
			throw new TlsFatalAlert(80);
		case 7:
			return CreateCipher_Cbc(cryptoParams, encryptionAlgorithm, 24, macAlgorithm);
		case 10:
			return CreateCipher_Aes_Gcm(cryptoParams, 16, 16);
		case 11:
			return CreateCipher_Aes_Gcm(cryptoParams, 32, 16);
		case 15:
			return CreateCipher_Aes_Ccm(cryptoParams, 16, 16);
		case 16:
			return CreateCipher_Aes_Ccm(cryptoParams, 16, 8);
		case 17:
			return CreateCipher_Aes_Ccm(cryptoParams, 32, 16);
		case 18:
			return CreateCipher_Aes_Ccm(cryptoParams, 32, 8);
		case 19:
			return CreateCipher_Camellia_Gcm(cryptoParams, 16, 16);
		case 20:
			return CreateCipher_Camellia_Gcm(cryptoParams, 32, 16);
		case 21:
			return CreateChaCha20Poly1305(cryptoParams);
		case 9:
		case 13:
		case 23:
			return CreateCipher_Cbc(cryptoParams, encryptionAlgorithm, 32, macAlgorithm);
		case 24:
			return CreateCipher_Aria_Gcm(cryptoParams, 16, 16);
		case 25:
			return CreateCipher_Aria_Gcm(cryptoParams, 32, 16);
		case 26:
			return CreateCipher_SM4_Ccm(cryptoParams);
		case 27:
			return CreateCipher_SM4_Gcm(cryptoParams);
		case 8:
		case 12:
		case 14:
		case 22:
		case 28:
			return CreateCipher_Cbc(cryptoParams, encryptionAlgorithm, 16, macAlgorithm);
		}
	}

	public override TlsDHDomain CreateDHDomain(TlsDHConfig dhConfig)
	{
		return new BcTlsDHDomain(this, dhConfig);
	}

	public override TlsECDomain CreateECDomain(TlsECConfig ecConfig)
	{
		return ecConfig.NamedGroup switch
		{
			30 => new BcX448Domain(this), 
			29 => new BcX25519Domain(this), 
			_ => new BcTlsECDomain(this, ecConfig), 
		};
	}

	public override TlsNonceGenerator CreateNonceGenerator(byte[] additionalSeedMaterial)
	{
		IDigest digest = CreateDigest(4);
		byte[] array = new byte[digest.GetDigestSize()];
		SecureRandom.NextBytes(array);
		DigestRandomGenerator digestRandomGenerator = new DigestRandomGenerator(digest);
		digestRandomGenerator.AddSeedMaterial(additionalSeedMaterial);
		digestRandomGenerator.AddSeedMaterial(array);
		return new BcTlsNonceGenerator(digestRandomGenerator);
	}

	public override bool HasAllRawSignatureAlgorithms()
	{
		if (!HasSignatureAlgorithm(7))
		{
			return !HasSignatureAlgorithm(8);
		}
		return false;
	}

	public override bool HasDHAgreement()
	{
		return true;
	}

	public override bool HasECDHAgreement()
	{
		return true;
	}

	public override bool HasEncryptionAlgorithm(int encryptionAlgorithm)
	{
		if ((uint)(encryptionAlgorithm - 1) <= 5u)
		{
			return false;
		}
		return true;
	}

	public override bool HasCryptoHashAlgorithm(int cryptoHashAlgorithm)
	{
		return true;
	}

	public override bool HasCryptoSignatureAlgorithm(int cryptoSignatureAlgorithm)
	{
		switch (cryptoSignatureAlgorithm)
		{
		default:
			return false;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
			return true;
		}
	}

	public override bool HasMacAlgorithm(int macAlgorithm)
	{
		return true;
	}

	public override bool HasNamedGroup(int namedGroup)
	{
		return NamedGroup.RefersToASpecificGroup(namedGroup);
	}

	public override bool HasRsaEncryption()
	{
		return true;
	}

	public override bool HasSignatureAlgorithm(short signatureAlgorithm)
	{
		switch (signatureAlgorithm)
		{
		default:
			return false;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 26:
		case 27:
		case 28:
			return true;
		}
	}

	public override bool HasSignatureAndHashAlgorithm(SignatureAndHashAlgorithm sigAndHashAlgorithm)
	{
		short signature = sigAndHashAlgorithm.Signature;
		if (sigAndHashAlgorithm.Hash == 1)
		{
			if (1 == signature)
			{
				return HasSignatureAlgorithm(signature);
			}
			return false;
		}
		return HasSignatureAlgorithm(signature);
	}

	public override bool HasSignatureScheme(int signatureScheme)
	{
		if (signatureScheme == 1800)
		{
			return false;
		}
		short signatureAlgorithm = SignatureScheme.GetSignatureAlgorithm(signatureScheme);
		if (SignatureScheme.GetCryptoHashAlgorithm(signatureScheme) == 1)
		{
			if (1 == signatureAlgorithm)
			{
				return HasSignatureAlgorithm(signatureAlgorithm);
			}
			return false;
		}
		return HasSignatureAlgorithm(signatureAlgorithm);
	}

	public override bool HasSrpAuthentication()
	{
		return true;
	}

	public override TlsSecret CreateSecret(byte[] data)
	{
		return AdoptLocalSecret(Arrays.Clone(data));
	}

	public override TlsSecret GenerateRsaPreMasterSecret(ProtocolVersion version)
	{
		byte[] array = new byte[48];
		SecureRandom.NextBytes(array);
		TlsUtilities.WriteVersion(version, array, 0);
		return AdoptLocalSecret(array);
	}

	public virtual IDigest CloneDigest(int cryptoHashAlgorithm, IDigest digest)
	{
		return cryptoHashAlgorithm switch
		{
			1 => new MD5Digest((MD5Digest)digest), 
			2 => new Sha1Digest((Sha1Digest)digest), 
			3 => new Sha224Digest((Sha224Digest)digest), 
			4 => new Sha256Digest((Sha256Digest)digest), 
			5 => new Sha384Digest((Sha384Digest)digest), 
			6 => new Sha512Digest((Sha512Digest)digest), 
			7 => new SM3Digest((SM3Digest)digest), 
			_ => throw new ArgumentException("invalid CryptoHashAlgorithm: " + cryptoHashAlgorithm), 
		};
	}

	public virtual IDigest CreateDigest(int cryptoHashAlgorithm)
	{
		return cryptoHashAlgorithm switch
		{
			1 => new MD5Digest(), 
			2 => new Sha1Digest(), 
			3 => new Sha224Digest(), 
			4 => new Sha256Digest(), 
			5 => new Sha384Digest(), 
			6 => new Sha512Digest(), 
			7 => new SM3Digest(), 
			_ => throw new ArgumentException("invalid CryptoHashAlgorithm: " + cryptoHashAlgorithm), 
		};
	}

	public override TlsHash CreateHash(int cryptoHashAlgorithm)
	{
		return new BcTlsHash(this, cryptoHashAlgorithm);
	}

	protected virtual IBlockCipher CreateBlockCipher(int encryptionAlgorithm)
	{
		switch (encryptionAlgorithm)
		{
		case 28:
			return CreateSM4Engine();
		case 22:
		case 23:
			return CreateAriaEngine();
		case 7:
			return CreateDesEdeEngine();
		case 8:
		case 9:
			return CreateAesEngine();
		default:
			throw new TlsFatalAlert(80);
		case 12:
		case 13:
			return CreateCamelliaEngine();
		case 14:
			return CreateSeedEngine();
		}
	}

	protected virtual IBlockCipher CreateCbcBlockCipher(IBlockCipher blockCipher)
	{
		return new CbcBlockCipher(blockCipher);
	}

	protected virtual IBlockCipher CreateCbcBlockCipher(int encryptionAlgorithm)
	{
		return CreateCbcBlockCipher(CreateBlockCipher(encryptionAlgorithm));
	}

	protected virtual TlsCipher CreateChaCha20Poly1305(TlsCryptoParameters cryptoParams)
	{
		BcChaCha20Poly1305 encryptCipher = new BcChaCha20Poly1305(isEncrypting: true);
		BcChaCha20Poly1305 decryptCipher = new BcChaCha20Poly1305(isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, 32, 16, 2);
	}

	protected virtual TlsAeadCipher CreateCipher_Aes_Ccm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		BcTlsAeadCipherImpl encryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Aes_Ccm(), isEncrypting: true);
		BcTlsAeadCipherImpl decryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Aes_Ccm(), isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, cipherKeySize, macSize, 1);
	}

	protected virtual TlsAeadCipher CreateCipher_Aes_Gcm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		BcTlsAeadCipherImpl encryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Aes_Gcm(), isEncrypting: true);
		BcTlsAeadCipherImpl decryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Aes_Gcm(), isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, cipherKeySize, macSize, 3);
	}

	protected virtual TlsAeadCipher CreateCipher_Aria_Gcm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		BcTlsAeadCipherImpl encryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Aria_Gcm(), isEncrypting: true);
		BcTlsAeadCipherImpl decryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Aria_Gcm(), isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, cipherKeySize, macSize, 3);
	}

	protected virtual TlsAeadCipher CreateCipher_Camellia_Gcm(TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
	{
		BcTlsAeadCipherImpl encryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Camellia_Gcm(), isEncrypting: true);
		BcTlsAeadCipherImpl decryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_Camellia_Gcm(), isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, cipherKeySize, macSize, 3);
	}

	protected virtual TlsCipher CreateCipher_Cbc(TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int cipherKeySize, int macAlgorithm)
	{
		BcTlsBlockCipherImpl encryptCipher = new BcTlsBlockCipherImpl(CreateCbcBlockCipher(encryptionAlgorithm), isEncrypting: true);
		BcTlsBlockCipherImpl decryptCipher = new BcTlsBlockCipherImpl(CreateCbcBlockCipher(encryptionAlgorithm), isEncrypting: false);
		TlsHmac clientMac = CreateMac(cryptoParams, macAlgorithm);
		TlsHmac serverMac = CreateMac(cryptoParams, macAlgorithm);
		return new TlsBlockCipher(cryptoParams, encryptCipher, decryptCipher, clientMac, serverMac, cipherKeySize);
	}

	protected virtual TlsAeadCipher CreateCipher_SM4_Ccm(TlsCryptoParameters cryptoParams)
	{
		BcTlsAeadCipherImpl encryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_SM4_Ccm(), isEncrypting: true);
		BcTlsAeadCipherImpl decryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_SM4_Ccm(), isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, 16, 16, 1);
	}

	protected virtual TlsAeadCipher CreateCipher_SM4_Gcm(TlsCryptoParameters cryptoParams)
	{
		BcTlsAeadCipherImpl encryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_SM4_Gcm(), isEncrypting: true);
		BcTlsAeadCipherImpl decryptCipher = new BcTlsAeadCipherImpl(CreateAeadBlockCipher_SM4_Gcm(), isEncrypting: false);
		return new TlsAeadCipher(cryptoParams, encryptCipher, decryptCipher, 16, 16, 3);
	}

	protected virtual TlsNullCipher CreateNullCipher(TlsCryptoParameters cryptoParams, int macAlgorithm)
	{
		return new TlsNullCipher(cryptoParams, CreateMac(cryptoParams, macAlgorithm), CreateMac(cryptoParams, macAlgorithm));
	}

	protected virtual IBlockCipher CreateAesEngine()
	{
		return new AesEngine();
	}

	protected virtual IBlockCipher CreateAriaEngine()
	{
		return new AriaEngine();
	}

	protected virtual IBlockCipher CreateCamelliaEngine()
	{
		return new CamelliaEngine();
	}

	protected virtual IBlockCipher CreateDesEdeEngine()
	{
		return new DesEdeEngine();
	}

	protected virtual IBlockCipher CreateSeedEngine()
	{
		return new SeedEngine();
	}

	protected virtual IBlockCipher CreateSM4Engine()
	{
		return new SM4Engine();
	}

	protected virtual IAeadBlockCipher CreateCcmMode(IBlockCipher engine)
	{
		return new CcmBlockCipher(engine);
	}

	protected virtual IAeadBlockCipher CreateGcmMode(IBlockCipher engine)
	{
		return new GcmBlockCipher(engine);
	}

	protected virtual IAeadBlockCipher CreateAeadBlockCipher_Aes_Ccm()
	{
		return CreateCcmMode(CreateAesEngine());
	}

	protected virtual IAeadBlockCipher CreateAeadBlockCipher_Aes_Gcm()
	{
		return CreateGcmMode(CreateAesEngine());
	}

	protected virtual IAeadBlockCipher CreateAeadBlockCipher_Aria_Gcm()
	{
		return CreateGcmMode(CreateAriaEngine());
	}

	protected virtual IAeadBlockCipher CreateAeadBlockCipher_Camellia_Gcm()
	{
		return CreateGcmMode(CreateCamelliaEngine());
	}

	protected virtual IAeadBlockCipher CreateAeadBlockCipher_SM4_Ccm()
	{
		return CreateCcmMode(CreateSM4Engine());
	}

	protected virtual IAeadBlockCipher CreateAeadBlockCipher_SM4_Gcm()
	{
		return CreateGcmMode(CreateSM4Engine());
	}

	public override TlsHmac CreateHmac(int macAlgorithm)
	{
		return CreateHmacForHash(TlsCryptoUtilities.GetHashForHmac(macAlgorithm));
	}

	public override TlsHmac CreateHmacForHash(int cryptoHashAlgorithm)
	{
		return new BcTlsHmac(new HMac(CreateDigest(cryptoHashAlgorithm)));
	}

	protected virtual TlsHmac CreateHmac_Ssl(int macAlgorithm)
	{
		return macAlgorithm switch
		{
			1 => new BcSsl3Hmac(CreateDigest(1)), 
			2 => new BcSsl3Hmac(CreateDigest(2)), 
			3 => new BcSsl3Hmac(CreateDigest(4)), 
			4 => new BcSsl3Hmac(CreateDigest(5)), 
			5 => new BcSsl3Hmac(CreateDigest(6)), 
			_ => throw new TlsFatalAlert(80), 
		};
	}

	protected virtual TlsHmac CreateMac(TlsCryptoParameters cryptoParams, int macAlgorithm)
	{
		if (TlsImplUtilities.IsSsl(cryptoParams))
		{
			return CreateHmac_Ssl(macAlgorithm);
		}
		return CreateHmac(macAlgorithm);
	}

	public override TlsSrp6Client CreateSrp6Client(TlsSrpConfig srpConfig)
	{
		BigInteger[] explicitNG = srpConfig.GetExplicitNG();
		Srp6GroupParameters group = new Srp6GroupParameters(explicitNG[0], explicitNG[1]);
		Srp6Client srp6Client = new Srp6Client();
		srp6Client.Init(group, CreateDigest(2), SecureRandom);
		return new BcTlsSrp6Client(srp6Client);
	}

	public override TlsSrp6Server CreateSrp6Server(TlsSrpConfig srpConfig, BigInteger srpVerifier)
	{
		BigInteger[] explicitNG = srpConfig.GetExplicitNG();
		Srp6GroupParameters group = new Srp6GroupParameters(explicitNG[0], explicitNG[1]);
		Srp6Server srp6Server = new Srp6Server();
		srp6Server.Init(group, srpVerifier, CreateDigest(2), SecureRandom);
		return new BcTlsSrp6Server(srp6Server);
	}

	public override TlsSrp6VerifierGenerator CreateSrp6VerifierGenerator(TlsSrpConfig srpConfig)
	{
		BigInteger[] explicitNG = srpConfig.GetExplicitNG();
		Srp6VerifierGenerator srp6VerifierGenerator = new Srp6VerifierGenerator();
		srp6VerifierGenerator.Init(explicitNG[0], explicitNG[1], CreateDigest(2));
		return new BcTlsSrp6VerifierGenerator(srp6VerifierGenerator);
	}

	public override TlsSecret HkdfInit(int cryptoHashAlgorithm)
	{
		return AdoptLocalSecret(new byte[TlsCryptoUtilities.GetHashOutputSize(cryptoHashAlgorithm)]);
	}
}
