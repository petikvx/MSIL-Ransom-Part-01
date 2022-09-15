using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public abstract class RsaUtilities
{
	private static readonly byte[] RSAPSSParams_256_A;

	private static readonly byte[] RSAPSSParams_384_A;

	private static readonly byte[] RSAPSSParams_512_A;

	private static readonly byte[] RSAPSSParams_256_B;

	private static readonly byte[] RSAPSSParams_384_B;

	private static readonly byte[] RSAPSSParams_512_B;

	static RsaUtilities()
	{
		AlgorithmIdentifier algorithmIdentifier = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha256);
		AlgorithmIdentifier algorithmIdentifier2 = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha384);
		AlgorithmIdentifier algorithmIdentifier3 = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha512);
		AlgorithmIdentifier algorithmIdentifier4 = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha256, DerNull.Instance);
		AlgorithmIdentifier algorithmIdentifier5 = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha384, DerNull.Instance);
		AlgorithmIdentifier algorithmIdentifier6 = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha512, DerNull.Instance);
		AlgorithmIdentifier maskGenAlgorithm = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier);
		AlgorithmIdentifier maskGenAlgorithm2 = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier2);
		AlgorithmIdentifier maskGenAlgorithm3 = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier3);
		AlgorithmIdentifier maskGenAlgorithm4 = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier4);
		AlgorithmIdentifier maskGenAlgorithm5 = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier5);
		AlgorithmIdentifier maskGenAlgorithm6 = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier6);
		DerInteger saltLength = new DerInteger(TlsCryptoUtilities.GetHashOutputSize(4));
		DerInteger saltLength2 = new DerInteger(TlsCryptoUtilities.GetHashOutputSize(5));
		DerInteger saltLength3 = new DerInteger(TlsCryptoUtilities.GetHashOutputSize(6));
		DerInteger trailerField = new DerInteger(1);
		try
		{
			RSAPSSParams_256_A = new RsassaPssParameters(algorithmIdentifier, maskGenAlgorithm, saltLength, trailerField).GetEncoded("DER");
			RSAPSSParams_384_A = new RsassaPssParameters(algorithmIdentifier2, maskGenAlgorithm2, saltLength2, trailerField).GetEncoded("DER");
			RSAPSSParams_512_A = new RsassaPssParameters(algorithmIdentifier3, maskGenAlgorithm3, saltLength3, trailerField).GetEncoded("DER");
			RSAPSSParams_256_B = new RsassaPssParameters(algorithmIdentifier4, maskGenAlgorithm4, saltLength, trailerField).GetEncoded("DER");
			RSAPSSParams_384_B = new RsassaPssParameters(algorithmIdentifier5, maskGenAlgorithm5, saltLength2, trailerField).GetEncoded("DER");
			RSAPSSParams_512_B = new RsassaPssParameters(algorithmIdentifier6, maskGenAlgorithm6, saltLength3, trailerField).GetEncoded("DER");
		}
		catch (IOException ex)
		{
			throw new InvalidOperationException(ex.Message);
		}
	}

	public static bool SupportsPkcs1(AlgorithmIdentifier pubKeyAlgID)
	{
		DerObjectIdentifier algorithm = pubKeyAlgID.Algorithm;
		if (!PkcsObjectIdentifiers.RsaEncryption.Equals(algorithm))
		{
			return X509ObjectIdentifiers.IdEARsa.Equals(algorithm);
		}
		return true;
	}

	public static bool SupportsPss_Pss(short signatureAlgorithm, AlgorithmIdentifier pubKeyAlgID)
	{
		DerObjectIdentifier algorithm = pubKeyAlgID.Algorithm;
		if (!PkcsObjectIdentifiers.IdRsassaPss.Equals(algorithm))
		{
			return false;
		}
		Asn1Encodable parameters = pubKeyAlgID.Parameters;
		if (parameters != null && !(parameters is DerNull))
		{
			byte[] encoded;
			try
			{
				encoded = parameters.ToAsn1Object().GetEncoded("DER");
			}
			catch (Exception)
			{
				return false;
			}
			byte[] a;
			byte[] a2;
			switch (signatureAlgorithm)
			{
			default:
				return false;
			case 9:
				a = RSAPSSParams_256_A;
				a2 = RSAPSSParams_256_B;
				break;
			case 10:
				a = RSAPSSParams_384_A;
				a2 = RSAPSSParams_384_B;
				break;
			case 11:
				a = RSAPSSParams_512_A;
				a2 = RSAPSSParams_512_B;
				break;
			}
			if (!Arrays.AreEqual(a, encoded))
			{
				return Arrays.AreEqual(a2, encoded);
			}
			return true;
		}
		if ((uint)(signatureAlgorithm - 9) <= 2u)
		{
			return true;
		}
		return false;
	}

	public static bool SupportsPss_Rsae(AlgorithmIdentifier pubKeyAlgID)
	{
		DerObjectIdentifier algorithm = pubKeyAlgID.Algorithm;
		return PkcsObjectIdentifiers.RsaEncryption.Equals(algorithm);
	}
}
