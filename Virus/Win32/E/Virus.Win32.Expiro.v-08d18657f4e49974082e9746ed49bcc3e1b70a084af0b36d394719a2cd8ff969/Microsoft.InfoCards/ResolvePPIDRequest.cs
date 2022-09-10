using System;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class ResolvePPIDRequest : UIAgentRequest
{
	private string m_selfIssuedCardId;

	private string m_managedCardId;

	private string m_ppid;

	public ResolvePPIDRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_ppid = Utility.DeserializeString(reader);
		m_managedCardId = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			InfoCard infoCard = new InfoCard(new Uri(m_managedCardId));
			infoCard.Get(connection);
			m_selfIssuedCardId = Utility.ResolvePPID(m_ppid, infoCard.IssuerIdentifierAsBytes, connection);
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		BinaryWriter writer = new BinaryWriter(outArgs, Encoding.Unicode);
		Utility.SerializeString(writer, m_selfIssuedCardId);
	}
}
