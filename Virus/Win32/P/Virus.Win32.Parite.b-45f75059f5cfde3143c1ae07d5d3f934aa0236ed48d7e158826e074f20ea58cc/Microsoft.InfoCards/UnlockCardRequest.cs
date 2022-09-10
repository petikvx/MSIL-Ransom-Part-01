using System;
using System.Globalization;
using System.IO;

namespace Microsoft.InfoCards;

internal class UnlockCardRequest : UIAgentRequest
{
	private InfoCard m_card;

	public UnlockCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		m_card = new InfoCard(base.InArgs);
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			m_card.Connection = connection;
			m_card.GetMasterKey(connection);
			m_card.Decrypt();
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			m_card.AgentSerialize(base.OutArgs, base.ParentRequest is GetTokenRequest, GetPolicy(), connection, new CultureInfo(base.ParentRequest.UserLanguage));
		}
		finally
		{
			connection.Close();
		}
	}
}
