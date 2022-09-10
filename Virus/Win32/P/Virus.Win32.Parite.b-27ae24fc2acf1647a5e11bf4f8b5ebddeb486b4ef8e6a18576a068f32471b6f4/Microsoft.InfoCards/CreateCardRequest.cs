using System;
using System.Globalization;
using System.IO;

namespace Microsoft.InfoCards;

internal class CreateCardRequest : UIAgentRequest
{
	private InfoCardPolicy m_policy;

	private InfoCard m_card;

	public CreateCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		m_policy = GetPolicy();
		m_card = InfoCard.NewCard(new CultureInfo(base.ParentRequest.UserLanguage));
	}

	protected override void OnMarshalOutArgs()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			Stream outArgs = base.OutArgs;
			m_card.AgentSerialize(outArgs, base.ParentRequest is GetTokenRequest, m_policy, connection, new CultureInfo(base.ParentRequest.UserLanguage));
		}
		finally
		{
			connection.Close();
		}
	}
}
