using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetLedgerRequest : UIAgentRequest
{
	private Uri m_cardId;

	private LedgerEntryCollection m_ledger;

	public GetLedgerRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
		InfoCardTrace.Assert(IntPtr.Zero != rpcHandle, "Null rpc handle", new object[0]);
		InfoCardTrace.Assert(null != inArgs, "Null inArgs", new object[0]);
		InfoCardTrace.Assert(null != outArgs, "Null out args", new object[0]);
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		InfoCardTrace.Assert(null != base.InArgs, "null request argument", new object[0]);
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_cardId = Utility.DeserializeUri(reader);
	}

	protected override void OnProcess()
	{
		InfoCardTrace.Assert(null != m_cardId, "No CardId passed to GetLedgerRequest", new object[0]);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			m_ledger = new LedgerEntryCollection(m_cardId);
			m_ledger.Get(connection);
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		InfoCardTrace.Assert(null != m_ledger, "No ledger collection exists to be serialized", new object[0]);
		m_ledger.Serialize(base.OutArgs);
	}
}
