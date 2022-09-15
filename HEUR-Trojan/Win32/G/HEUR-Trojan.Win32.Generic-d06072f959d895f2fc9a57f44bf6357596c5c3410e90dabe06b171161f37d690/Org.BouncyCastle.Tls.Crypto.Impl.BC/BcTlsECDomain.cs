using System;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDomain : TlsECDomain
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly TlsECConfig m_ecConfig;

	protected readonly ECDomainParameters m_ecDomainParameters;

	public static BcTlsSecret CalculateBasicAgreement(BcTlsCrypto crypto, ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
	{
		ECDHBasicAgreement eCDHBasicAgreement = new ECDHBasicAgreement();
		eCDHBasicAgreement.Init(privateKey);
		byte[] data = BigIntegers.AsUnsignedByteArray(n: eCDHBasicAgreement.CalculateAgreement(publicKey), length: eCDHBasicAgreement.GetFieldSize());
		return crypto.AdoptLocalSecret(data);
	}

	public static ECDomainParameters GetDomainParameters(TlsECConfig ecConfig)
	{
		return GetDomainParameters(ecConfig.NamedGroup);
	}

	public static ECDomainParameters GetDomainParameters(int namedGroup)
	{
		if (!NamedGroup.RefersToASpecificCurve(namedGroup))
		{
			return null;
		}
		string curveName = NamedGroup.GetCurveName(namedGroup);
		X9ECParameters byName = CustomNamedCurves.GetByName(curveName);
		if (byName == null)
		{
			byName = ECNamedCurveTable.GetByName(curveName);
			if (byName == null)
			{
				return null;
			}
		}
		return new ECDomainParameters(byName.Curve, byName.G, byName.N, byName.H, byName.GetSeed());
	}

	public BcTlsECDomain(BcTlsCrypto crypto, TlsECConfig ecConfig)
	{
		m_crypto = crypto;
		m_ecConfig = ecConfig;
		m_ecDomainParameters = GetDomainParameters(ecConfig);
	}

	public virtual BcTlsSecret CalculateECDHAgreement(ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
	{
		return CalculateBasicAgreement(m_crypto, privateKey, publicKey);
	}

	public virtual TlsAgreement CreateECDH()
	{
		return new BcTlsECDH(this);
	}

	public virtual ECPoint DecodePoint(byte[] encoding)
	{
		return m_ecDomainParameters.Curve.DecodePoint(encoding);
	}

	public virtual ECPublicKeyParameters DecodePublicKey(byte[] encoding)
	{
		try
		{
			return new ECPublicKeyParameters(DecodePoint(encoding), m_ecDomainParameters);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(47, alertCause);
		}
	}

	public virtual byte[] EncodePoint(ECPoint point)
	{
		return point.GetEncoded(compressed: false);
	}

	public virtual byte[] EncodePublicKey(ECPublicKeyParameters publicKey)
	{
		return EncodePoint(publicKey.Q);
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator();
		eCKeyPairGenerator.Init(new ECKeyGenerationParameters(m_ecDomainParameters, m_crypto.SecureRandom));
		return eCKeyPairGenerator.GenerateKeyPair();
	}
}
