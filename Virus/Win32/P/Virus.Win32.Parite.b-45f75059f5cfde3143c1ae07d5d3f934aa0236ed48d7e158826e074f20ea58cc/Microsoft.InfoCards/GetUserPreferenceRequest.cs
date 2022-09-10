using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class GetUserPreferenceRequest : UIAgentRequest
{
	private UserPreference m_userPreference;

	public GetUserPreferenceRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
		m_userPreference = null;
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			m_userPreference = UserPreference.Get(connection);
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		if (m_userPreference != null)
		{
			m_userPreference.Serialize(base.OutArgs);
		}
	}
}
