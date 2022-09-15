using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public abstract class AbstractTlsCrypto : TlsCrypto
{
	public abstract SecureRandom SecureRandom { get; }

	public abstract bool HasAllRawSignatureAlgorithms();

	public abstract bool HasDHAgreement();

	public abstract bool HasECDHAgreement();

	public abstract bool HasEncryptionAlgorithm(int encryptionAlgorithm);

	public abstract bool HasCryptoHashAlgorithm(int cryptoHashAlgorithm);

	public abstract bool HasCryptoSignatureAlgorithm(int cryptoSignatureAlgorithm);

	public abstract bool HasMacAlgorithm(int macAlgorithm);

	public abstract bool HasNamedGroup(int namedGroup);

	public abstract bool HasRsaEncryption();

	public abstract bool HasSignatureAlgorithm(short signatureAlgorithm);

	public abstract bool HasSignatureAndHashAlgorithm(SignatureAndHashAlgorithm sigAndHashAlgorithm);

	public abstract bool HasSignatureScheme(int signatureScheme);

	public abstract bool HasSrpAuthentication();

	public abstract TlsSecret CreateSecret(byte[] data);

	public abstract TlsSecret GenerateRsaPreMasterSecret(ProtocolVersion clientVersion);

	public abstract TlsCertificate CreateCertificate(byte[] encoding);

	public abstract TlsCipher CreateCipher(TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int macAlgorithm);

	public abstract TlsDHDomain CreateDHDomain(TlsDHConfig dhConfig);

	public abstract TlsECDomain CreateECDomain(TlsECConfig ecConfig);

	public virtual TlsSecret AdoptSecret(TlsSecret secret)
	{
		if (!(secret is AbstractTlsSecret))
		{
			throw new ArgumentException("unrecognized TlsSecret - cannot copy data: " + Platform.GetTypeName(secret));
		}
		AbstractTlsSecret abstractTlsSecret = (AbstractTlsSecret)secret;
		return CreateSecret(abstractTlsSecret.CopyData());
	}

	public abstract TlsHash CreateHash(int cryptoHashAlgorithm);

	public abstract TlsHmac CreateHmac(int macAlgorithm);

	public abstract TlsHmac CreateHmacForHash(int cryptoHashAlgorithm);

	public abstract TlsNonceGenerator CreateNonceGenerator(byte[] additionalSeedMaterial);

	public abstract TlsSrp6Client CreateSrp6Client(TlsSrpConfig srpConfig);

	public abstract TlsSrp6Server CreateSrp6Server(TlsSrpConfig srpConfig, BigInteger srpVerifier);

	public abstract TlsSrp6VerifierGenerator CreateSrp6VerifierGenerator(TlsSrpConfig srpConfig);

	public abstract TlsSecret HkdfInit(int cryptoHashAlgorithm);
}