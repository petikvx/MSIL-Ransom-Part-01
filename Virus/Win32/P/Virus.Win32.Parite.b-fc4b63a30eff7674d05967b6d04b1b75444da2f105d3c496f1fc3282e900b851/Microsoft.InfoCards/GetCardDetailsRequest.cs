using System;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class GetCardDetailsRequest : UIAgentRequest
{
	private InfoCard m_card;

	private bool m_cardMatchesPolicyRequirements;

	public GetCardDetailsRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		Stream inArgs = base.InArgs;
		m_card = new InfoCard(inArgs);
		m_card.GetExtendedInformation().Deserialize(inArgs);
		m_card.GetRPIdentityRequirement().Deserialize(inArgs);
		m_card.GetClaims().Deserialize(inArgs);
	}

	protected override void OnProcess()
	{
		m_cardMatchesPolicyRequirements = m_card.DoesCardMatchPolicySet(GetPolicy());
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		BinaryWriter binaryWriter = new BinaryWriter(outArgs, Encoding.Unicode);
		binaryWriter.Write(m_cardMatchesPolicyRequirements);
	}
}
