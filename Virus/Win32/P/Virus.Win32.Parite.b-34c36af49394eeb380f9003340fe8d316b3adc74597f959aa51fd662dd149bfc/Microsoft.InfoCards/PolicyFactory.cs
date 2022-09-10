using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.IdentityModel.Selectors;
using System.ServiceModel;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class PolicyFactory
{
	private PolicyFactory()
	{
	}

	public static Policy CreatePolicyFromUnwrappedPolicyXml(string originalPolicyXml)
	{
		string rstPolicyXml = string.Format(CultureInfo.InvariantCulture, "<{0}:{1} xmlns:{0}='{2}'>{3}</{0}:{1}>", XmlNames.WSSecurityPolicyXmlSoap2005.Instance.DefaultPrefix, XmlNames.WSSecurityPolicyXmlSoap2005.Instance.RequestSecurityTokenTemplate, XmlNames.WSSecurityPolicyXmlSoap2005.Instance.Namespace, originalPolicyXml);
		return new Policy(originalPolicyXml, rstPolicyXml);
	}

	public static InfoCardPolicy CreatePolicyForCustomTokenProvider(EndpointAddress immediateTokenRecipient, IssuedSecurityTokenParameters issuedTokenParameters, ProtocolProfile profile)
	{
		ParsedPolicy policy = CreateParsedPolicy(issuedTokenParameters.CreateRequestParameters(profile.MsgSecurityVersion, (SecurityTokenSerializer)(object)profile.TokenSerializer));
		return new InfoCardPolicy(immediateTokenRecipient, issuedTokenParameters.get_IssuerAddress(), policy, PolicyUsageContext.GetToken, null, 0u, null, isManaged: false);
	}

	public static InfoCardPolicy CreatePolicyForGetBrowserTokenRequest(CardSpacePolicyElement policyElement, Uri recipientPolicyNoticeLink, uint recipientPolicyNoticeVersion, RecipientIdentity recipientIdentity, PolicyUsageContext usageContext)
	{
		EndpointAddress immediateTokenRecipient = null;
		if (!string.IsNullOrEmpty(policyElement.get_Target().OuterXml))
		{
			immediateTokenRecipient = CreateEndpointAddressFromString(policyElement.get_Target().OuterXml);
		}
		EndpointAddress issuer = null;
		if (policyElement.get_Issuer() != null && !string.IsNullOrEmpty(policyElement.get_Issuer().OuterXml))
		{
			issuer = CreateEndpointAddressFromString(policyElement.get_Issuer().OuterXml);
		}
		ParsedPolicy policy = CreateParsedPolicy(policyElement.get_Parameters());
		return new InfoCardPolicy(immediateTokenRecipient, issuer, policy, usageContext, (null != recipientPolicyNoticeLink) ? recipientPolicyNoticeLink.ToString() : null, recipientPolicyNoticeVersion, recipientIdentity, isManaged: false);
	}

	public static InfoCardPolicy CreatePolicyForIntermediateGetBrowserTokenRequest(CardSpacePolicyElement policyElement, Uri recipientPolicyNoticeLink, uint recipientPolicyNoticeVersion, RecipientIdentity recipientIdentity)
	{
		EndpointAddress immediateTokenRecipient = null;
		if (!string.IsNullOrEmpty(policyElement.get_Target().OuterXml))
		{
			immediateTokenRecipient = CreateEndpointAddressFromString(policyElement.get_Target().OuterXml);
		}
		EndpointAddress issuer = null;
		if (policyElement.get_Issuer() != null && !string.IsNullOrEmpty(policyElement.get_Issuer().OuterXml))
		{
			issuer = CreateEndpointAddressFromString(policyElement.get_Issuer().OuterXml);
		}
		ParsedPolicy policy = CreateParsedPolicy(policyElement.get_Parameters());
		return new InfoCardPolicy(immediateTokenRecipient, issuer, policy, PolicyUsageContext.Intermediate, (null != recipientPolicyNoticeLink) ? recipientPolicyNoticeLink.ToString() : null, recipientPolicyNoticeVersion, recipientIdentity, isManaged: false);
	}

	public static InfoCardPolicy CreatePolicyForGetTokenRequest(BinaryReader reader, string recipientXml, string issuerXml, string policyXml, bool isManaged)
	{
		if (!string.IsNullOrEmpty(policyXml))
		{
			string xml = string.Format(CultureInfo.InvariantCulture, "<{0}:{1} xmlns:{0}='{2}'>{3}</{0}:{1}>", XmlNames.WSSecurityPolicyXmlSoap2005.Instance.DefaultPrefix, XmlNames.WSSecurityPolicyXmlSoap2005.Instance.RequestSecurityTokenTemplate, XmlNames.WSSecurityPolicyXmlSoap2005.Instance.Namespace, policyXml);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			Collection<XmlElement> collection = new Collection<XmlElement>();
			foreach (XmlElement childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				collection.Add(childNode);
			}
			ParsedPolicy policy = CreateParsedPolicy(collection);
			return new InfoCardPolicy((!string.IsNullOrEmpty(recipientXml)) ? CreateEndpointAddressFromString(recipientXml) : null, (!string.IsNullOrEmpty(issuerXml)) ? CreateEndpointAddressFromString(issuerXml) : null, policy, PolicyUsageContext.GetToken, null, 0u, null, isManaged);
		}
		if (!isManaged)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidPolicySpecified")));
		}
		return new InfoCardPolicy((!string.IsNullOrEmpty(recipientXml)) ? CreateEndpointAddressFromString(recipientXml) : null, (!string.IsNullOrEmpty(issuerXml)) ? CreateEndpointAddressFromString(issuerXml) : null, null, PolicyUsageContext.GetToken, null, 0u, null, isManaged);
	}

	private static ParsedPolicy CreateParsedPolicy(IEnumerable<XmlElement> elements)
	{
		try
		{
			XmlElement xmlElement = null;
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			foreach (XmlElement element in elements)
			{
				stringBuilder2.Append(element.OuterXml);
				if (element.LocalName == "SecondaryParameters" && element.NamespaceURI == "http://docs.oasis-open.org/ws-sx/ws-trust/200512")
				{
					xmlElement = element;
				}
				else
				{
					stringBuilder.Append(element.OuterXml);
				}
			}
			if (xmlElement != null)
			{
				return new ParsedPolicy(stringBuilder2.ToString(), stringBuilder.ToString(), xmlElement.InnerXml);
			}
			return new ParsedPolicy(stringBuilder2.ToString(), stringBuilder.ToString(), null);
		}
		catch (XmlException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidPolicySpecified"), inner));
		}
	}

	private static EndpointAddress CreateEndpointAddressFromString(string fragment)
	{
		try
		{
			using XmlReader xmlReader = LoadXmlIntoReader(fragment.Trim());
			xmlReader.MoveToElement();
			return EndpointAddress.ReadFrom(XmlDictionaryReader.CreateDictionaryReader(xmlReader));
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("ServiceInvalidEprInPolicy"), ex));
		}
	}

	private static XmlReader LoadXmlIntoReader(string fragment)
	{
		return InfoCardSchemas.CreateReader(fragment);
	}
}
