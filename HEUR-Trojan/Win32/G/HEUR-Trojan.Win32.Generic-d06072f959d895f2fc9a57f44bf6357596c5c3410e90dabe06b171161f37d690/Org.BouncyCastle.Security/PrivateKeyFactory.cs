using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security;

public sealed class PrivateKeyFactory
{
	private PrivateKeyFactory()
	{
	}

	public static AsymmetricKeyParameter CreateKey(byte[] privateKeyInfoData)
	{
		return CreateKey(PrivateKeyInfo.GetInstance(Asn1Object.FromByteArray(privateKeyInfoData)));
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return CreateKey(PrivateKeyInfo.GetInstance(Asn1Object.FromStream(inStr)));
	}

	public static AsymmetricKeyParameter CreateKey(PrivateKeyInfo keyInfo)
	{
		AlgorithmIdentifier privateKeyAlgorithm = keyInfo.PrivateKeyAlgorithm;
		DerObjectIdentifier algorithm = privateKeyAlgorithm.Algorithm;
		if (!algorithm.Equals(PkcsObjectIdentifiers.RsaEncryption) && !algorithm.Equals(X509ObjectIdentifiers.IdEARsa) && !algorithm.Equals(PkcsObjectIdentifiers.IdRsassaPss) && !algorithm.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
		{
			if (algorithm.Equals(PkcsObjectIdentifiers.DhKeyAgreement))
			{
				DHParameter dHParameter = new DHParameter(Asn1Sequence.GetInstance(privateKeyAlgorithm.Parameters.ToAsn1Object()));
				DerInteger obj = (DerInteger)keyInfo.ParsePrivateKey();
				return new DHPrivateKeyParameters(parameters: new DHParameters(l: dHParameter.L?.IntValue ?? 0, p: dHParameter.P, g: dHParameter.G, q: null), x: obj.Value, algorithmOid: algorithm);
			}
			if (algorithm.Equals(OiwObjectIdentifiers.ElGamalAlgorithm))
			{
				ElGamalParameter elGamalParameter = new ElGamalParameter(Asn1Sequence.GetInstance(privateKeyAlgorithm.Parameters.ToAsn1Object()));
				return new ElGamalPrivateKeyParameters(((DerInteger)keyInfo.ParsePrivateKey()).Value, new ElGamalParameters(elGamalParameter.P, elGamalParameter.G));
			}
			if (algorithm.Equals(X9ObjectIdentifiers.IdDsa))
			{
				DerInteger obj2 = (DerInteger)keyInfo.ParsePrivateKey();
				Asn1Encodable parameters2 = privateKeyAlgorithm.Parameters;
				DsaParameters parameters3 = null;
				if (parameters2 != null)
				{
					DsaParameter instance = DsaParameter.GetInstance(parameters2.ToAsn1Object());
					parameters3 = new DsaParameters(instance.P, instance.Q, instance.G);
				}
				return new DsaPrivateKeyParameters(obj2.Value, parameters3);
			}
			if (algorithm.Equals(X9ObjectIdentifiers.IdECPublicKey))
			{
				X962Parameters instance2 = X962Parameters.GetInstance(privateKeyAlgorithm.Parameters.ToAsn1Object());
				X9ECParameters x9ECParameters = ((!instance2.IsNamedCurve) ? new X9ECParameters((Asn1Sequence)instance2.Parameters) : ECKeyPairGenerator.FindECCurveByOid((DerObjectIdentifier)instance2.Parameters));
				BigInteger key = ECPrivateKeyStructure.GetInstance(keyInfo.ParsePrivateKey()).GetKey();
				if (instance2.IsNamedCurve)
				{
					return new ECPrivateKeyParameters("EC", key, (DerObjectIdentifier)instance2.Parameters);
				}
				ECDomainParameters parameters4 = new ECDomainParameters(x9ECParameters.Curve, x9ECParameters.G, x9ECParameters.N, x9ECParameters.H, x9ECParameters.GetSeed());
				return new ECPrivateKeyParameters(key, parameters4);
			}
			if (algorithm.Equals(CryptoProObjectIdentifiers.GostR3410x2001))
			{
				Gost3410PublicKeyAlgParameters instance3 = Gost3410PublicKeyAlgParameters.GetInstance(privateKeyAlgorithm.Parameters.ToAsn1Object());
				X9ECParameters byOidX = ECGost3410NamedCurves.GetByOidX9(instance3.PublicKeyParamSet);
				if (byOidX == null)
				{
					throw new ArgumentException("Unrecognized curve OID for GostR3410x2001 private key");
				}
				Asn1Object asn1Object = keyInfo.ParsePrivateKey();
				ECPrivateKeyStructure eCPrivateKeyStructure = ((!(asn1Object is DerInteger)) ? ECPrivateKeyStructure.GetInstance(asn1Object) : new ECPrivateKeyStructure(byOidX.N.BitLength, ((DerInteger)asn1Object).PositiveValue));
				return new ECPrivateKeyParameters("ECGOST3410", eCPrivateKeyStructure.GetKey(), instance3.PublicKeyParamSet);
			}
			if (algorithm.Equals(CryptoProObjectIdentifiers.GostR3410x94))
			{
				Gost3410PublicKeyAlgParameters instance4 = Gost3410PublicKeyAlgParameters.GetInstance(privateKeyAlgorithm.Parameters);
				Asn1Object asn1Object2 = keyInfo.ParsePrivateKey();
				BigInteger x = ((!(asn1Object2 is DerInteger)) ? new BigInteger(1, Arrays.Reverse(Asn1OctetString.GetInstance(asn1Object2).GetOctets())) : DerInteger.GetInstance(asn1Object2).PositiveValue);
				return new Gost3410PrivateKeyParameters(x, instance4.PublicKeyParamSet);
			}
			if (algorithm.Equals(EdECObjectIdentifiers.id_X25519))
			{
				return new X25519PrivateKeyParameters(GetRawKey(keyInfo));
			}
			if (algorithm.Equals(EdECObjectIdentifiers.id_X448))
			{
				return new X448PrivateKeyParameters(GetRawKey(keyInfo));
			}
			if (algorithm.Equals(EdECObjectIdentifiers.id_Ed25519))
			{
				return new Ed25519PrivateKeyParameters(GetRawKey(keyInfo));
			}
			if (algorithm.Equals(EdECObjectIdentifiers.id_Ed448))
			{
				return new Ed448PrivateKeyParameters(GetRawKey(keyInfo));
			}
			if (!algorithm.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512) && !algorithm.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256))
			{
				throw new SecurityUtilityException("algorithm identifier in private key not recognised");
			}
			Gost3410PublicKeyAlgParameters instance5 = Gost3410PublicKeyAlgParameters.GetInstance(keyInfo.PrivateKeyAlgorithm.Parameters);
			Asn1Object asn1Object3 = keyInfo.PrivateKeyAlgorithm.Parameters.ToAsn1Object();
			ECGost3410Parameters dp;
			BigInteger d;
			if (asn1Object3 is Asn1Sequence && (Asn1Sequence.GetInstance(asn1Object3).Count == 2 || Asn1Sequence.GetInstance(asn1Object3).Count == 3))
			{
				X9ECParameters byOidX2 = ECGost3410NamedCurves.GetByOidX9(instance5.PublicKeyParamSet);
				dp = new ECGost3410Parameters(new ECNamedDomainParameters(instance5.PublicKeyParamSet, byOidX2), instance5.PublicKeyParamSet, instance5.DigestParamSet, instance5.EncryptionParamSet);
				Asn1OctetString privateKeyData = keyInfo.PrivateKeyData;
				if (privateKeyData.GetOctets().Length != 32 && privateKeyData.GetOctets().Length != 64)
				{
					Asn1Encodable asn1Encodable = keyInfo.ParsePrivateKey();
					if (asn1Encodable is DerInteger)
					{
						d = DerInteger.GetInstance(asn1Encodable).PositiveValue;
					}
					else
					{
						byte[] bytes = Arrays.Reverse(Asn1OctetString.GetInstance(asn1Encodable).GetOctets());
						d = new BigInteger(1, bytes);
					}
				}
				else
				{
					byte[] bytes2 = Arrays.Reverse(privateKeyData.GetOctets());
					d = new BigInteger(1, bytes2);
				}
			}
			else
			{
				X962Parameters instance6 = X962Parameters.GetInstance(keyInfo.PrivateKeyAlgorithm.Parameters);
				if (instance6.IsNamedCurve)
				{
					DerObjectIdentifier instance7 = DerObjectIdentifier.GetInstance(instance6.Parameters);
					X9ECParameters byOid = ECNamedCurveTable.GetByOid(instance7);
					dp = new ECGost3410Parameters(new ECNamedDomainParameters(instance7, byOid), instance5.PublicKeyParamSet, instance5.DigestParamSet, instance5.EncryptionParamSet);
				}
				else if (instance6.IsImplicitlyCA)
				{
					dp = null;
				}
				else
				{
					X9ECParameters instance8 = X9ECParameters.GetInstance(instance6.Parameters);
					dp = new ECGost3410Parameters(new ECNamedDomainParameters(algorithm, instance8), instance5.PublicKeyParamSet, instance5.DigestParamSet, instance5.EncryptionParamSet);
				}
				Asn1Encodable asn1Encodable2 = keyInfo.ParsePrivateKey();
				d = ((!(asn1Encodable2 is DerInteger)) ? ECPrivateKeyStructure.GetInstance(asn1Encodable2).GetKey() : DerInteger.GetInstance(asn1Encodable2).Value);
			}
			return new ECPrivateKeyParameters(d, new ECGost3410Parameters(dp, instance5.PublicKeyParamSet, instance5.DigestParamSet, instance5.EncryptionParamSet));
		}
		RsaPrivateKeyStructure instance9 = RsaPrivateKeyStructure.GetInstance(keyInfo.ParsePrivateKey());
		return new RsaPrivateCrtKeyParameters(instance9.Modulus, instance9.PublicExponent, instance9.PrivateExponent, instance9.Prime1, instance9.Prime2, instance9.Exponent1, instance9.Exponent2, instance9.Coefficient);
	}

	private static byte[] GetRawKey(PrivateKeyInfo keyInfo)
	{
		return Asn1OctetString.GetInstance(keyInfo.ParsePrivateKey()).GetOctets();
	}

	public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, EncryptedPrivateKeyInfo encInfo)
	{
		return CreateKey(PrivateKeyInfoFactory.CreatePrivateKeyInfo(passPhrase, encInfo));
	}

	public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, byte[] encryptedPrivateKeyInfoData)
	{
		return DecryptKey(passPhrase, Asn1Object.FromByteArray(encryptedPrivateKeyInfoData));
	}

	public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, Stream encryptedPrivateKeyInfoStream)
	{
		return DecryptKey(passPhrase, Asn1Object.FromStream(encryptedPrivateKeyInfoStream));
	}

	private static AsymmetricKeyParameter DecryptKey(char[] passPhrase, Asn1Object asn1Object)
	{
		return DecryptKey(passPhrase, EncryptedPrivateKeyInfo.GetInstance(asn1Object));
	}

	public static byte[] EncryptKey(DerObjectIdentifier algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
	{
		return EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, key).GetEncoded();
	}

	public static byte[] EncryptKey(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
	{
		return EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, key).GetEncoded();
	}
}
