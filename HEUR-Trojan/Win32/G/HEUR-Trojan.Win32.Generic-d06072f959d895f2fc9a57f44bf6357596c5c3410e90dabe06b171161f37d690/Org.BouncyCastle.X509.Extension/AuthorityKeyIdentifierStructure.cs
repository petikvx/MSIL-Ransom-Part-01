using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;

namespace Org.BouncyCastle.X509.Extension;

public class AuthorityKeyIdentifierStructure : AuthorityKeyIdentifier
{
	public AuthorityKeyIdentifierStructure(Asn1OctetString encodedValue)
		: base((Asn1Sequence)X509ExtensionUtilities.FromExtensionValue(encodedValue))
	{
	}

	private static Asn1Sequence FromCertificate(X509Certificate certificate)
	{
		try
		{
			GeneralName name = new GeneralName(PrincipalUtilities.GetIssuerX509Principal(certificate));
			if (certificate.Version == 3)
			{
				Asn1OctetString extensionValue = certificate.GetExtensionValue(X509Extensions.SubjectKeyIdentifier);
				if (extensionValue != null)
				{
					return (Asn1Sequence)new AuthorityKeyIdentifier(((Asn1OctetString)X509ExtensionUtilities.FromExtensionValue(extensionValue)).GetOctets(), new GeneralNames(name), certificate.SerialNumber).ToAsn1Object();
				}
			}
			return (Asn1Sequence)new AuthorityKeyIdentifier(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(certificate.GetPublicKey()), new GeneralNames(name), certificate.SerialNumber).ToAsn1Object();
		}
		catch (Exception exception)
		{
			throw new CertificateParsingException("Exception extracting certificate details", exception);
		}
	}

	private static Asn1Sequence FromKey(AsymmetricKeyParameter pubKey)
	{
		try
		{
			return (Asn1Sequence)new AuthorityKeyIdentifier(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pubKey)).ToAsn1Object();
		}
		catch (Exception ex)
		{
			throw new InvalidKeyException("can't process key: " + ex);
		}
	}

	public AuthorityKeyIdentifierStructure(X509Certificate certificate)
		: base(FromCertificate(certificate))
	{
	}

	public AuthorityKeyIdentifierStructure(AsymmetricKeyParameter pubKey)
		: base(FromKey(pubKey))
	{
	}
}
