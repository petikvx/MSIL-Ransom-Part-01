using System.Xml;

namespace Microsoft.InfoCards;

internal class RequestSecurityTokenForRemoteTokenFactory : RequestSecurityToken
{
	public RequestSecurityTokenForRemoteTokenFactory(RequestSecurityTokenParameters rstParams)
		: base(rstParams)
	{
	}

	protected override void WriteAppliesToElement()
	{
		switch (AppliesToBehaviorDecisionTable.GetAppliesToBehaviorDecisionForRst(base.Policy, m_rstParams.Card.RequireAppliesto))
		{
		case AppliesToBehaviorDecision.SendRPAppliesTo:
			base.Serializer.WriteAppliesToElement(base.Policy.PolicyAppliesTo, m_rstParams.Version);
			break;
		case AppliesToBehaviorDecision.SendCustomAppliesTo:
			base.Serializer.WriteAppliesToElement(base.Policy.ImmediateTokenRecipient.Address, m_rstParams.Version);
			break;
		}
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
			flag = m_rstParams.DiscloseOptionalClaims && !OptionalClaimsExceedCard(m_rstParams.Card, m_rstParams.Policy);
		}
		switch (AppliesToBehaviorDecisionTable.GetAppliesToBehaviorDecisionForRst(base.Policy, m_rstParams.Card.RequireAppliesto))
		{
		default:
			flag = false;
			break;
		case AppliesToBehaviorDecision.SendRPAppliesTo:
		case AppliesToBehaviorDecision.SendCustomAppliesTo:
			break;
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
		WriteRequestTypeElement();
		WriteInfoCardReferenceElement();
		WriteClaimsElement();
		WriteKeyTypeElement();
		WriteKeySupportingElements();
		WriteAppliesToElement();
		WritePPIDElement();
		WriteEncryptionAlgorithmElement();
		WritePassOnElements();
		WriteDisplayTokenElement();
		WriteUnprocessedPolicyElements();
		WriteSecondaryParametersElement();
		WriteEndElement();
	}

	private bool OptionalClaimsExceedCard(InfoCard card, InfoCardPolicy policy)
	{
		InfoCardClaimCollection claims = card.GetClaims();
		bool result = false;
		string[] optionalClaims = policy.OptionalClaims;
		foreach (string key in optionalClaims)
		{
			if (!claims.ContainsKey(key))
			{
				result = true;
			}
		}
		return result;
	}
}
