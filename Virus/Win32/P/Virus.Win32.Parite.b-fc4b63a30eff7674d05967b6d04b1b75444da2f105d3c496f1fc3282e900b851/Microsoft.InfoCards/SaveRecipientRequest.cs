using System;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SaveRecipientRequest : UIAgentRequest
{
	private Recipient m_recipient;

	public SaveRecipientRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
		InfoCardTrace.Assert(IntPtr.Zero != rpcHandle, "Null RPC handle", new object[0]);
		InfoCardTrace.Assert(null != inArgs, "Null InArgs", new object[0]);
		InfoCardTrace.Assert(null != outArgs, "Null outArgs", new object[0]);
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		InfoCardTrace.Assert(null != base.InArgs, "Null inArgs", new object[0]);
		m_recipient = new Recipient(base.InArgs);
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			InfoCardTrace.Assert(null != m_recipient, " Null Recipient", new object[0]);
			connection.BeginTransaction();
			try
			{
				m_recipient.Save(connection);
				connection.CommitTransaction();
			}
			catch
			{
				connection.RollbackTransaction();
				throw;
			}
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
