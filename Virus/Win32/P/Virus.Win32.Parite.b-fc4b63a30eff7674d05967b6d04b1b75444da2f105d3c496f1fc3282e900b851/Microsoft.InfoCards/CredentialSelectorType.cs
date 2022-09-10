namespace Microsoft.InfoCards;

internal enum CredentialSelectorType
{
	InvalidSelector = -1,
	X509CertificateIssuerNameSelector,
	X509CertificateIssuerSerialNoSelector,
	X509CertificateKeyHashSelector,
	X509CertificateKeyIdSelector,
	UserNameSelector,
	SpnSelector,
	SelfIssuedCardIdSelector,
	RsaKeyValueSelector,
	UserPrincipalNameSelector
}
