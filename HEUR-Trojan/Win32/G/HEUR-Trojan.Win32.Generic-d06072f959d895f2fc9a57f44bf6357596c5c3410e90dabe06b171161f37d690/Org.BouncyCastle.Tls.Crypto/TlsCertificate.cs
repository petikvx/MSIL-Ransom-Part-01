using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsCertificate
{
	BigInteger SerialNumber { get; }

	string SigAlgOid { get; }

	TlsEncryptor CreateEncryptor(int tlsCertificateRole);

	TlsVerifier CreateVerifier(short signatureAlgorithm);

	TlsVerifier CreateVerifier(int signatureScheme);

	byte[] GetEncoded();

	byte[] GetExtension(DerObjectIdentifier extensionOid);

	Asn1Encodable GetSigAlgParams();

	short GetLegacySignatureAlgorithm();

	bool SupportsSignatureAlgorithm(short signatureAlgorithm);

	bool SupportsSignatureAlgorithmCA(short signatureAlgorithm);

	TlsCertificate CheckUsageInRole(int tlsCertificateRole);
}
