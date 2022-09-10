using System;
using System.Collections;
using System.IO;

namespace Microsoft.InfoCards;

internal class DeleteStoreRequest : UIAgentRequest
{
	public DeleteStoreRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parentRequest)
		: base(rpcHandle, inArgs, outArgs, parentRequest)
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
			connection.BeginTransaction();
			try
			{
				QueryParameter queryParameter = DataSource.CreateDeleteStoreTypeQuery();
				ICollection collection = (ICollection)connection.Query(QueryDetails.Identifiers, connection.LocalDataSource, queryParameter);
				if (collection != null && collection.Count > 0)
				{
					foreach (DataRow item in collection)
					{
						connection.Delete(item);
					}
				}
				connection.CommitTransaction();
				AuditLog.AuditStoreDeletion();
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
