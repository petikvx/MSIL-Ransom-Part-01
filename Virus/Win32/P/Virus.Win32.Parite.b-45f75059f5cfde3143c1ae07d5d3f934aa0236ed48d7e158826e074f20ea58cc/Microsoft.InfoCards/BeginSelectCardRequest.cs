using System;
using System.IO;

namespace Microsoft.InfoCards;

internal class BeginSelectCardRequest : UIAgentAsyncBeginRequest
{
	private InfoCard m_card;

	public BeginSelectCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalAsyncInArgs(BinaryReader reader)
	{
		m_card = new InfoCard(reader.BaseStream);
		m_card.GetExtendedInformation().Deserialize(reader.BaseStream);
		m_card.GetRPIdentityRequirement().Deserialize(reader.BaseStream);
		m_card.GetClaims().Deserialize(reader.BaseStream);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			InfoCardMasterKey masterKey = m_card.GetMasterKey(connection);
			if (m_card.IsPinProtected)
			{
				masterKey.Decrypt(masterKey.GetPinHelper(m_card.Pin));
			}
		}
		finally
		{
			connection.Close();
		}
	}

	protected override object AsyncExecute(AsyncParams asyncParam)
	{
		return ((GetTokenRequest)base.ParentRequest).SelectCard(m_card, m_card.IsSelfIssued);
	}

	protected override void AsyncCancel()
	{
		((GetTokenRequest)base.ParentRequest).CancelSelectCard();
	}
}
