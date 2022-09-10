using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RequestSecurityTokenForGetBrowserToken : RequestSecurityToken
{
	public RequestSecurityTokenForGetBrowserToken(RequestSecurityTokenParameters rstParams)
		: base(rstParams)
	{
	}

	protected override void WriteKeyTypeElement()
	{
		InfoCardTrace.Assert(base.ProtocolVersionProfile.WSTrust.KeyTypeBearer.ToString() == base.Policy.GetKeyTypeString(), "Only no proof key allowed in browser case", new object[0]);
		base.Serializer.WriteKeyTypeElement(base.Policy.GetKeyTypeString());
	}

	protected override void WriteRequestTypeElement()
	{
		base.Serializer.WriteRequestTypeElement(base.ProtocolVersionProfile.WSTrust.IssueRequestType);
	}

	protected override void WriteAppliesToElement()
	{
		GetBrowserTokenRequest.WriteSourceUrlAppliesTo((XmlWriter)(object)base.Writer, m_rstParams.BrowserTokenParams, base.ProtocolVersionProfile);
	}

	protected override void WriteSecondaryParametersElement()
	{
		if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 != base.ProtocolVersionProfile.WSTrust.Version)
		{
			return;
		}
		bool flag = true;
		if (base.Policy.OptionalClaims.Length > 0)
		{
			flag = m_rstParams.DiscloseOptionalClaims;
		}
		if (flag)
		{
			if (base.Policy.RelyingPartyPolicy != null)
			{
				base.Serializer.WriteSecondaryParametersElement(base.Policy.RelyingPartyPolicy.PolicyXml);
			}
			else
			{
				base.Serializer.WriteSecondaryParametersElement(base.Policy.ClientPolicy.PolicyXml);
			}
		}
	}

	protected override void CustomWriteBodyContents(XmlDictionaryWriter writer)
	{
		InitializeWriters(writer);
		WriteRSTOpeningElement();
		WriteKeyTypeElement();
		WriteRequestTypeElement();
		WriteAppliesToElement();
		WriteClaimsElement();
		WriteTokenTypeElement();
		WriteSecondaryParametersElement();
		WriteEndElement();
	}
}
