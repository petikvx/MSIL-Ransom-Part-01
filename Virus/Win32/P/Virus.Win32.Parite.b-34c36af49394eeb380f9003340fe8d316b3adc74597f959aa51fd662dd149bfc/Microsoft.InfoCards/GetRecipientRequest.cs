using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetRecipientRequest : UIAgentRequest
{
	private string m_recipientId;

	private Recipient m_recipient;

	public GetRecipientRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_recipientId = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		InfoCardTrace.Assert(null != m_recipientId, "null thumb print", new object[0]);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			List<QueryParameter> list = new List<QueryParameter>();
			QueryParameter item = new QueryParameter("ix_objecttype", -3);
			list.Add(item);
			item = new QueryParameter("ix_name", m_recipientId);
			list.Add(item);
			DataRow singleRow = connection.GetSingleRow(list.ToArray());
			if (singleRow != null)
			{
				m_recipient = new Recipient(new MemoryStream(singleRow.GetDataField()));
			}
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter writer = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		InfoCardTrace.Assert(null != m_recipient, "null recipient", new object[0]);
		m_recipient.Serialize(writer);
	}
}
