using System;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SetUserPreferenceRequest : UIAgentRequest
{
	private UserPreference m_userPreferences;

	public SetUserPreferenceRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		InfoCardTrace.Assert(base.InArgs.Length > 0L, "The user preferences must be specified", new object[0]);
		m_userPreferences = new UserPreference(base.InArgs);
	}

	protected override void OnProcess()
	{
		InfoCardTrace.Assert(null != m_userPreferences, "OnMarshalInArgs must be called prior to calling OnProcess", new object[0]);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			connection.BeginTransaction();
			try
			{
				m_userPreferences.Save(connection);
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
