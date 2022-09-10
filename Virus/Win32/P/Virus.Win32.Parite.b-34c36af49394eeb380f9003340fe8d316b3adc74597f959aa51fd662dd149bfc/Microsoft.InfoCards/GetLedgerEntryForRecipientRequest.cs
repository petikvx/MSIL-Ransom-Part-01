using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetLedgerEntryForRecipientRequest : UIAgentRequest
{
	private Uri m_cardId;

	private string m_recipientId;

	private byte[] m_bytes;

	public GetLedgerEntryForRecipientRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		InfoCardTrace.Assert(base.InArgs.Length > 0L, "The user preferences must be specified", new object[0]);
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_cardId = Utility.DeserializeUri(reader);
		m_recipientId = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		InfoCardTrace.Assert(null != m_cardId, "The card Id must not be null", new object[0]);
		InfoCardTrace.Assert(!string.IsNullOrEmpty(m_recipientId), "The thumbPrint must be specified", new object[0]);
		List<QueryParameter> list = new List<QueryParameter>();
		QueryParameter item = new QueryParameter("ix_objecttype", -1);
		list.Add(item);
		item = new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_cardId.ToString()));
		list.Add(item);
		list.Add(new QueryParameter("ix_name", m_recipientId));
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			DataRow singleRow = connection.GetSingleRow(list.ToArray());
			if (singleRow != null)
			{
				m_bytes = singleRow.GetDataField();
			}
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		if (m_bytes != null)
		{
			base.OutArgs.Write(m_bytes, 0, m_bytes.Length);
		}
	}
}
