using System;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RecipientIdentity
{
	private EndpointAddress m_address;

	private string m_identifier = string.Empty;

	private string m_organizationIdentifier = string.Empty;

	private bool m_hasBeenValidated;

	public EndpointAddress Address => m_address;

	protected bool HasBeenValidated
	{
		get
		{
			return m_hasBeenValidated;
		}
		set
		{
			m_hasBeenValidated = value;
		}
	}

	protected string Identifier
	{
		set
		{
			m_identifier = value;
		}
	}

	protected string OrganizationIdentifier
	{
		set
		{
			m_organizationIdentifier = value;
		}
	}

	public static RecipientIdentity CreateIdentity(EndpointAddress epr, bool validate)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (epr.get_Identity() is X509CertificateEndpointIdentity)
		{
			if (((X509CertificateEndpointIdentity)epr.get_Identity()).get_Certificates() != null && ((X509CertificateEndpointIdentity)epr.get_Identity()).get_Certificates().Count >= 1)
			{
				RecipientIdentity recipientIdentity = new X509RecipientIdentity(epr, ((X509CertificateEndpointIdentity)epr.get_Identity()).get_Certificates());
				if (validate)
				{
					recipientIdentity.Validate();
				}
				return recipientIdentity;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException());
		}
		if (epr.get_Identity() == null)
		{
			RecipientIdentity recipientIdentity2 = new RecipientIdentity(epr);
			if (validate)
			{
				recipientIdentity2.Validate();
			}
			return recipientIdentity2;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("UnsupportedIdentityType")));
	}

	public RecipientIdentity(EndpointAddress epr)
	{
		m_address = epr;
	}

	public virtual void Validate()
	{
		if (!m_hasBeenValidated)
		{
			using (SHA256 sHA = new SHA256Managed())
			{
				m_identifier = Convert.ToBase64String(sHA.ComputeHash(Encoding.Unicode.GetBytes(m_address.get_Uri().Host)));
				m_organizationIdentifier = m_identifier;
			}
			m_hasBeenValidated = true;
		}
	}

	public virtual string GetIdentifier()
	{
		InfoCardTrace.Assert(HasBeenValidated, "Identity has not been validated", new object[0]);
		return m_identifier;
	}

	public virtual string GetOrganizationIdentifier()
	{
		InfoCardTrace.Assert(HasBeenValidated, "Identity has not been validated", new object[0]);
		return m_organizationIdentifier;
	}

	public virtual string GetName()
	{
		return m_address.get_Uri().Host;
	}
}
