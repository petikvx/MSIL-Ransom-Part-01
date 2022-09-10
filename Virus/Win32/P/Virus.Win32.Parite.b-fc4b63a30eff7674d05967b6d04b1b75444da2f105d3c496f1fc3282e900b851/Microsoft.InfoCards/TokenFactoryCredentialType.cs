namespace Microsoft.InfoCards;

internal enum TokenFactoryCredentialType
{
	Invalid = 0,
	LocalCredential = -1,
	UserNamePasswordCredential = 1,
	SelfIssuedCredential = 2,
	X509CertificateCredential = 3,
	KerberosCredential = 4
}
