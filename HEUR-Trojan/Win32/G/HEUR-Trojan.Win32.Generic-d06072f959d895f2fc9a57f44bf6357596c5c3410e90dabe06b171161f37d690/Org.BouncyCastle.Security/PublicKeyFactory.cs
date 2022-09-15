using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security;

public sealed class PublicKeyFactory
{
	private PublicKeyFactory()
	{
	}

	public static AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
	{
		return CreateKey(SubjectPublicKeyInfo.GetInstance(Asn1Object.FromByteArray(keyInfoData)));
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return CreateKey(SubjectPublicKeyInfo.GetInstance(Asn1Object.FromStream(inStr)));
	}

	public static AsymmetricKeyParameter CreateKey(SubjectPublicKeyInfo keyInfo)
	{
		AlgorithmIdentifier algorithmID = keyInfo.AlgorithmID;
		DerObjectIdentifier algorithm = algorithmID.Algorithm;
		if (!algorithm.Equals(PkcsObjectIdentifiers.RsaEncryption) && !algorithm.Equals(X509ObjectIdentifiers.IdEARsa) && !algorithm.Equals(PkcsObjectIdentifiers.IdRsassaPss) && !algorithm.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
		{
			if (algorithm.Equals(X9ObjectIdentifiers.DHPublicNumber))
			{
				Asn1Sequence instance = Asn1Sequence.GetInstance(algorithmID.Parameters.ToAsn1Object());
				BigInteger value = DHPublicKey.GetInstance(keyInfo.ParsePublicKey()).Y.Value;
				if (IsPkcsDHParam(instance))
				{
					return ReadPkcsDHParam(algorithm, value, instance);
				}
				DHDomainParameters instance2 = DHDomainParameters.GetInstance(instance);
				BigInteger value2 = instance2.P.Value;
				BigInteger value3 = instance2.G.Value;
				BigInteger value4 = instance2.Q.Value;
				BigInteger j = null;
				if (instance2.J != null)
				{
					j = instance2.J.Value;
				}
				DHValidationParameters validation = null;
				DHValidationParms validationParms = instance2.ValidationParms;
				if (validationParms != null)
				{
					byte[] bytes = validationParms.Seed.GetBytes();
					BigInteger value5 = validationParms.PgenCounter.Value;
					validation = new DHValidationParameters(bytes, value5.IntValue);
				}
				return new DHPublicKeyParameters(value, new DHParameters(value2, value3, value4, j, validation));
			}
			if (algorithm.Equals(PkcsObjectIdentifiers.DhKeyAgreement))
			{
				Asn1Sequence instance3 = Asn1Sequence.GetInstance(algorithmID.Parameters.ToAsn1Object());
				DerInteger derInteger = (DerInteger)keyInfo.ParsePublicKey();
				return ReadPkcsDHParam(algorithm, derInteger.Value, instance3);
			}
			if (algorithm.Equals(OiwObjectIdentifiers.ElGamalAlgorithm))
			{
				ElGamalParameter elGamalParameter = new ElGamalParameter(Asn1Sequence.GetInstance(algorithmID.Parameters.ToAsn1Object()));
				return new ElGamalPublicKeyParameters(((DerInteger)keyInfo.ParsePublicKey()).Value, new ElGamalParameters(elGamalParameter.P, elGamalParameter.G));
			}
			if (!algorithm.Equals(X9ObjectIdentifiers.IdDsa) && !algorithm.Equals(OiwObjectIdentifiers.DsaWithSha1))
			{
				if (algorithm.Equals(X9ObjectIdentifiers.IdECPublicKey))
				{
					X962Parameters instance4 = X962Parameters.GetInstance(algorithmID.Parameters.ToAsn1Object());
					X9ECParameters x9ECParameters = ((!instance4.IsNamedCurve) ? new X9ECParameters((Asn1Sequence)instance4.Parameters) : ECKeyPairGenerator.FindECCurveByOid((DerObjectIdentifier)instance4.Parameters));
					Asn1OctetString s = new DerOctetString(keyInfo.PublicKeyData.GetBytes());
					ECPoint point = new X9ECPoint(x9ECParameters.Curve, s).Point;
					if (instance4.IsNamedCurve)
					{
						return new ECPublicKeyParameters("EC", point, (DerObjectIdentifier)instance4.Parameters);
					}
					ECDomainParameters parameters = new ECDomainParameters(x9ECParameters);
					return new ECPublicKeyParameters(point, parameters);
				}
				if (algorithm.Equals(CryptoProObjectIdentifiers.GostR3410x2001))
				{
					DerObjectIdentifier publicKeyParamSet = Gost3410PublicKeyAlgParameters.GetInstance(algorithmID.Parameters).PublicKeyParamSet;
					X9ECParameters byOidX = ECGost3410NamedCurves.GetByOidX9(publicKeyParamSet);
					if (byOidX == null)
					{
						return null;
					}
					Asn1OctetString asn1OctetString;
					try
					{
						asn1OctetString = (Asn1OctetString)keyInfo.ParsePublicKey();
					}
					catch (IOException innerException)
					{
						throw new ArgumentException("error recovering GOST3410_2001 public key", innerException);
					}
					int num = 32;
					int num2 = 64;
					byte[] octets = asn1OctetString.GetOctets();
					if (octets.Length != 64)
					{
						throw new ArgumentException("invalid length for GOST3410_2001 public key");
					}
					byte[] array = new byte[1 + num2];
					array[0] = 4;
					for (int i = 1; i <= num; i++)
					{
						array[i] = octets[num - i];
						array[i + num] = octets[num2 - i];
					}
					ECPoint q = byOidX.Curve.DecodePoint(array);
					return new ECPublicKeyParameters("ECGOST3410", q, publicKeyParamSet);
				}
				if (algorithm.Equals(CryptoProObjectIdentifiers.GostR3410x94))
				{
					Gost3410PublicKeyAlgParameters instance5 = Gost3410PublicKeyAlgParameters.GetInstance(algorithmID.Parameters);
					Asn1OctetString asn1OctetString2;
					try
					{
						asn1OctetString2 = (Asn1OctetString)keyInfo.ParsePublicKey();
					}
					catch (IOException innerException2)
					{
						throw new ArgumentException("error recovering GOST3410_94 public key", innerException2);
					}
					byte[] bytes2 = Arrays.Reverse(asn1OctetString2.GetOctets());
					return new Gost3410PublicKeyParameters(new BigInteger(1, bytes2), instance5.PublicKeyParamSet);
				}
				if (algorithm.Equals(EdECObjectIdentifiers.id_X25519))
				{
					return new X25519PublicKeyParameters(GetRawKey(keyInfo));
				}
				if (algorithm.Equals(EdECObjectIdentifiers.id_X448))
				{
					return new X448PublicKeyParameters(GetRawKey(keyInfo));
				}
				if (algorithm.Equals(EdECObjectIdentifiers.id_Ed25519))
				{
					return new Ed25519PublicKeyParameters(GetRawKey(keyInfo));
				}
				if (algorithm.Equals(EdECObjectIdentifiers.id_Ed448))
				{
					return new Ed448PublicKeyParameters(GetRawKey(keyInfo));
				}
				if (!algorithm.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256) && !algorithm.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512))
				{
					throw new SecurityUtilityException("algorithm identifier in public key not recognised: " + algorithm);
				}
				Gost3410PublicKeyAlgParameters instance6 = Gost3410PublicKeyAlgParameters.GetInstance(algorithmID.Parameters);
				DerObjectIdentifier publicKeyParamSet2 = instance6.PublicKeyParamSet;
				ECGost3410Parameters eCGost3410Parameters = new ECGost3410Parameters(new ECNamedDomainParameters(publicKeyParamSet2, ECGost3410NamedCurves.GetByOidX9(publicKeyParamSet2)), publicKeyParamSet2, instance6.DigestParamSet, instance6.EncryptionParamSet);
				Asn1OctetString asn1OctetString3;
				try
				{
					asn1OctetString3 = (Asn1OctetString)keyInfo.ParsePublicKey();
				}
				catch (IOException innerException3)
				{
					throw new ArgumentException("error recovering GOST3410_2012 public key", innerException3);
				}
				int num3 = 32;
				if (algorithm.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512))
				{
					num3 = 64;
				}
				int num4 = 2 * num3;
				byte[] octets2 = asn1OctetString3.GetOctets();
				if (octets2.Length != num4)
				{
					throw new ArgumentException("invalid length for GOST3410_2012 public key");
				}
				byte[] array2 = new byte[1 + num4];
				array2[0] = 4;
				for (int k = 1; k <= num3; k++)
				{
					array2[k] = octets2[num3 - k];
					array2[k + num3] = octets2[num4 - k];
				}
				return new ECPublicKeyParameters(eCGost3410Parameters.Curve.DecodePoint(array2), eCGost3410Parameters);
			}
			DerInteger obj = (DerInteger)keyInfo.ParsePublicKey();
			Asn1Encodable parameters2 = algorithmID.Parameters;
			DsaParameters parameters3 = null;
			if (parameters2 != null)
			{
				DsaParameter instance7 = DsaParameter.GetInstance(parameters2.ToAsn1Object());
				parameters3 = new DsaParameters(instance7.P, instance7.Q, instance7.G);
			}
			return new DsaPublicKeyParameters(obj.Value, parameters3);
		}
		RsaPublicKeyStructure instance8 = RsaPublicKeyStructure.GetInstance(keyInfo.ParsePublicKey());
		return new RsaKeyParameters(isPrivate: false, instance8.Modulus, instance8.PublicExponent);
	}

	private static byte[] GetRawKey(SubjectPublicKeyInfo keyInfo)
	{
		return keyInfo.PublicKeyData.GetOctets();
	}

	private static bool IsPkcsDHParam(Asn1Sequence seq)
	{
		if (seq.Count == 2)
		{
			return true;
		}
		if (seq.Count > 3)
		{
			return false;
		}
		DerInteger instance = DerInteger.GetInstance(seq[2]);
		DerInteger instance2 = DerInteger.GetInstance(seq[0]);
		return instance.Value.CompareTo(BigInteger.ValueOf(instance2.Value.BitLength)) <= 0;
	}

	private static DHPublicKeyParameters ReadPkcsDHParam(DerObjectIdentifier algOid, BigInteger y, Asn1Sequence seq)
	{
		DHParameter dHParameter = new DHParameter(seq);
		int l = dHParameter.L?.IntValue ?? 0;
		DHParameters parameters = new DHParameters(dHParameter.P, dHParameter.G, null, l);
		return new DHPublicKeyParameters(y, parameters, algOid);
	}
}
