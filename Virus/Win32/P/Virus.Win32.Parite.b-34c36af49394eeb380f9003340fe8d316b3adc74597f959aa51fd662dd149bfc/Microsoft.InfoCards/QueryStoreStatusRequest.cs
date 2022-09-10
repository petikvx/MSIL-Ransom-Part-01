using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class QueryStoreStatusRequest : UIAgentRequest
{
	private bool m_storeStatus;

	public QueryStoreStatusRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
		OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			m_storeStatus = connection.IsDataSourceCleared(connection.LocalDataSource);
			if (m_storeStatus)
			{
				connection.ResetDataSourceClearedFlag(connection.LocalDataSource);
			}
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		BinaryWriter binaryWriter = new BinaryWriter(outArgs);
		binaryWriter.Write(m_storeStatus);
	}
}
