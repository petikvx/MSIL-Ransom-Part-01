using System;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace Server.Helper;

public static class CreateCertificate
{
	public static X509Certificate2 CreateCertificateAuthority(string caName, int keyStrength)
	{
		SecureRandom random = new SecureRandom();
		RsaKeyPairGenerator rsaKeyPairGenerator = new RsaKeyPairGenerator();
		rsaKeyPairGenerator.Init(new KeyGenerationParameters(random, keyStrength));
		AsymmetricCipherKeyPair asymmetricCipherKeyPair = rsaKeyPairGenerator.GenerateKeyPair();
		X509V3CertificateGenerator x509V3CertificateGenerator = new X509V3CertificateGenerator();
		X509Name issuerDN = new X509Name("CN=" + caName + ",OU=qwqdanchun,O=DcRat By qwqdanchun,L=SH,C=CN");
		X509Name subjectDN = new X509Name("CN=DcRat");
		BigInteger serialNumber = BigInteger.ProbablePrime(160, new SecureRandom());
		x509V3CertificateGenerator.SetSerialNumber(serialNumber);
		x509V3CertificateGenerator.SetSubjectDN(subjectDN);
		x509V3CertificateGenerator.SetIssuerDN(issuerDN);
		x509V3CertificateGenerator.SetNotAfter(DateTime.UtcNow.Subtract(new TimeSpan(-3650, 0, 0, 0)));
		x509V3CertificateGenerator.SetNotBefore(DateTime.UtcNow.Subtract(new TimeSpan(285, 0, 0, 0)));
		x509V3CertificateGenerator.SetPublicKey(asymmetricCipherKeyPair.Public);
		x509V3CertificateGenerator.AddExtension(X509Extensions.SubjectKeyIdentifier, critical: false, new SubjectKeyIdentifierStructure(asymmetricCipherKeyPair.Public));
		x509V3CertificateGenerator.AddExtension(X509Extensions.BasicConstraints, critical: true, new BasicConstraints(cA: true));
		ISignatureFactory signatureCalculatorFactory = new Asn1SignatureFactory("SHA512WITHRSA", asymmetricCipherKeyPair.Private, random);
		return new X509Certificate2(DotNetUtilities.ToX509Certificate(x509V3CertificateGenerator.Generate(signatureCalculatorFactory)))
		{
			PrivateKey = DotNetUtilities.ToRSA(asymmetricCipherKeyPair.Private as RsaPrivateCrtKeyParameters)
		};
	}
}
