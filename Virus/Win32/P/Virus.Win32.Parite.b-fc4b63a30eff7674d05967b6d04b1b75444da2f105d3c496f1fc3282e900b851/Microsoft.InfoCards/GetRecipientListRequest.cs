using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class GetRecipientListRequest : UIAgentRequest
{
	private IList<Recipient> m_recipientList;

	public GetRecipientListRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			IList<DataRow> list = (IList<DataRow>)connection.Query(QueryDetails.FullRow, new QueryParameter("ix_objecttype", -3));
			if (list == null)
			{
				return;
			}
			IList<Recipient> list2 = new List<Recipient>(list.Count);
			foreach (DataRow item in list)
			{
				list2.Add(new Recipient(new MemoryStream(item.GetDataField())));
			}
			m_recipientList = list2;
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		uint value = 0u;
		if (m_recipientList != null)
		{
			value = (uint)m_recipientList.Count;
			binaryWriter.Write(value);
			{
				foreach (Recipient recipient in m_recipientList)
				{
					recipient.Serialize(binaryWriter);
				}
				return;
			}
		}
		binaryWriter.Write(value);
	}
}
