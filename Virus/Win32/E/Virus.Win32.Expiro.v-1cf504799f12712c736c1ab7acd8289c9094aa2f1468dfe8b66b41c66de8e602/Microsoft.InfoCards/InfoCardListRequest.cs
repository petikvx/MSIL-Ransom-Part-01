using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Microsoft.InfoCards;

internal class InfoCardListRequest : UIAgentRequest
{
	private InfoCardPolicy m_policy;

	private IList<InfoCard> m_allCards;

	public InfoCardListRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
		m_policy = GetPolicy();
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		IList<DataRow> allCards = GetAllCards();
		if (allCards == null || allCards.Count == 0)
		{
			return;
		}
		IList<InfoCard> list = new List<InfoCard>(allCards.Count);
		for (int i = 0; i < allCards.Count; i++)
		{
			byte[] dataField = allCards[i].GetDataField();
			try
			{
				using MemoryStream stream = new MemoryStream(dataField);
				list.Add(new InfoCard(stream));
			}
			finally
			{
				Array.Clear(dataField, 0, dataField.Length);
			}
		}
		m_allCards = list;
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		BinaryWriter binaryWriter = new BinaryWriter(outArgs);
		if (m_allCards != null && m_allCards.Count != 0)
		{
			StoreConnection connection = StoreConnection.GetConnection();
			try
			{
				binaryWriter.Write(m_allCards.Count);
				for (int i = 0; i < m_allCards.Count; i++)
				{
					binaryWriter.Flush();
					m_allCards[i].AgentSerialize(outArgs, base.ParentRequest is GetTokenRequest, m_policy, connection, new CultureInfo(base.ParentRequest.UserLanguage));
				}
				binaryWriter.Flush();
				return;
			}
			finally
			{
				if (m_allCards != null)
				{
					foreach (InfoCard allCard in m_allCards)
					{
						allCard.ClearSensitiveData();
					}
				}
				connection.Close();
			}
		}
		binaryWriter.Write(0);
	}

	private IList<DataRow> GetAllCards()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			return (IList<DataRow>)connection.Query(QueryDetails.FullRow, connection.LocalDataSource, new QueryParameter("ix_objecttype", 1));
		}
		finally
		{
			connection.Close();
		}
	}
}
