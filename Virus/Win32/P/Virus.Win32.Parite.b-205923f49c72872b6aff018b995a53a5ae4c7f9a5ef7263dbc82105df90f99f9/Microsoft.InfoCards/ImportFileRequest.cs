using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ImportFileRequest : UIAgentRequest
{
	public ImportFileRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		RoamingStoreFile context = base.ParentRequest.GetContext<RoamingStoreFile>();
		if (context == null || context.Cards == null)
		{
			return;
		}
		try
		{
			StoreConnection connection = StoreConnection.GetConnection();
			try
			{
				connection.BeginTransaction();
				try
				{
					foreach (InfoCard card in context.Cards)
					{
						List<QueryParameter> list = new List<QueryParameter>();
						list.Add(new QueryParameter("ix_objecttype", 1));
						list.Add(new QueryParameter("ix_globalid", GlobalId.DeriveFrom(card.Id.ToString())));
						DataRow singleRow = connection.GetSingleRow(QueryDetails.FullRow, list.ToArray());
						if (singleRow != null)
						{
							using MemoryStream stream = new MemoryStream(singleRow.GetDataField());
							InfoCard infoCard = new InfoCard(stream);
							if (infoCard.LastUpdate < card.LastUpdate)
							{
								card.IsImported = true;
								card.InstalledOn = DateTime.Now;
								card.Save(connection);
							}
						}
						else
						{
							card.IsImported = true;
							card.InstalledOn = DateTime.Now;
							card.Save(connection);
						}
					}
					connection.CommitTransaction();
					AuditLog.AuditStoreImport();
				}
				catch (Exception ex)
				{
					connection.RollbackTransaction();
					if (InfoCardTrace.IsFatal(ex))
					{
						throw;
					}
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportStoreException(SR.GetString("InvalidImportFile"), ex));
				}
			}
			finally
			{
				connection.Close();
			}
		}
		finally
		{
			context.Clear();
		}
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
