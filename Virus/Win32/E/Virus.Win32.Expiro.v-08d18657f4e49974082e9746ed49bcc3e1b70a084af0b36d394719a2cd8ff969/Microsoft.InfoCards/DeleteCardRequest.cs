using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class DeleteCardRequest : UIAgentRequest
{
	private Uri m_cardId;

	public DeleteCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_cardId = Utility.DeserializeUri(reader);
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			connection.BeginTransaction();
			try
			{
				DataRow singleRow = connection.GetSingleRow(QueryDetails.FullRow, new QueryParameter("ix_globalid", GlobalId.DeriveFrom(m_cardId.ToString())));
				if (singleRow != null)
				{
					byte[] dataField = singleRow.GetDataField();
					try
					{
						using MemoryStream stream = new MemoryStream(dataField);
						InfoCard infoCard = new InfoCard(stream);
						_ = infoCard.Name;
					}
					finally
					{
						connection.Delete(singleRow);
						Array.Clear(dataField, 0, dataField.Length);
					}
				}
				List<QueryParameter> list = new List<QueryParameter>();
				QueryParameter item = new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_cardId.ToString()));
				list.Add(item);
				ICollection collection = (ICollection)connection.Query(QueryDetails.Identifiers, list.ToArray());
				if (collection != null && collection.Count > 0)
				{
					foreach (DataRow item2 in collection)
					{
						connection.Delete(item2);
					}
				}
				connection.CommitTransaction();
				AuditLog.AuditCardDeletion();
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
