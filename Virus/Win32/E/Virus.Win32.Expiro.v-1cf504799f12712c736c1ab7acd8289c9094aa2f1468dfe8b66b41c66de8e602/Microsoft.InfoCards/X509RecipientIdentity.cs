using System;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class X509RecipientIdentity : RecipientIdentity
{
	private X509Certificate2Collection m_certificates;

	private Recipient.RecipientCertParameters m_recipientParams;

	private bool isChainTrusted;

	public Recipient.RecipientCertParameters RecipientParams => m_recipientParams;

	public X509Certificate2 LeafCertificate => m_certificates[0];

	public X509RecipientIdentity(EndpointAddress epr, X509Certificate2Collection certificates)
		: base(epr)
	{
		m_certificates = certificates;
	}

	public override void Validate()
	{
		if (!base.HasBeenValidated)
		{
			isChainTrusted = ValidateCertificate();
			base.Identifier = Recipient.CertGetRecipientIdHash(LeafCertificate, m_certificates, isChainTrusted, out m_recipientParams);
			base.OrganizationIdentifier = Recipient.CertGetRecipientOrganizationIdHash(LeafCertificate, m_certificates, ValidateCertificate());
			base.HasBeenValidated = true;
		}
	}

	public override string GetName()
	{
		string text = LeafCertificate.FriendlyName;
		if (string.IsNullOrEmpty(text))
		{
			text = LeafCertificate.GetNameInfo(X509NameType.SimpleName, forIssuer: false);
		}
		return text;
	}

	private bool ValidateCertificate()
	{
		//IL_0018: Expected O, but got Unknown
		bool chainTrustPassed = false;
		try
		{
			InfoCardX509Validator.ValidateChainOrPeer(LeafCertificate, m_certificates, out chainTrustPassed);
			return chainTrustPassed;
		}
		catch (SecurityTokenValidationException val)
		{
			SecurityTokenValidationException inner = val;
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("RecipientCertificateNotValid"), (Exception)(object)inner));
		}
	}
}
