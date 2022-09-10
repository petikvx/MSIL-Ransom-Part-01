using System;
using System.Globalization;
using System.IO;

namespace Microsoft.InfoCards;

internal class SaveCardRequest : UIAgentRequest
{
	private InfoCard m_card;

	public SaveCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		Stream inArgs = base.InArgs;
		m_card = new InfoCard(inArgs);
		m_card.GetExtendedInformation().Deserialize(inArgs);
		m_card.GetRPIdentityRequirement().Deserialize(inArgs);
		m_card.GetClaims().Deserialize(inArgs);
	}

	protected override void OnProcess()
	{
		if (m_card == null)
		{
			return;
		}
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			connection.BeginTransaction();
			try
			{
				m_card.LastUpdate = DateTime.UtcNow;
				m_card.Save(connection);
				connection.CommitTransaction();
				if (m_card.IsSelfIssued)
				{
					AuditLog.AuditCardWritten();
				}
				else
				{
					AuditLog.AuditCardImport();
				}
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
		Stream outArgs = base.OutArgs;
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			m_card.AgentSerialize(outArgs, base.ParentRequest is GetTokenRequest, GetPolicy(), connection, new CultureInfo(base.ParentRequest.UserLanguage));
		}
		finally
		{
			connection.Close();
		}
	}
}
