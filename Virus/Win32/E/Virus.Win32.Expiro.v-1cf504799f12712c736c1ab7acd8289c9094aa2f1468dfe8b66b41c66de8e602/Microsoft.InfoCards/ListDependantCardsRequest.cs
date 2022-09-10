using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class ListDependantCardsRequest : UIAgentRequest
{
	private Uri m_selfIssuedCardId;

	private List<InfoCard> m_allCards = new List<InfoCard>();

	public ListDependantCardsRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_selfIssuedCardId = new Uri(Utility.DeserializeString(reader));
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			IList<DataRow> list = (IList<DataRow>)connection.Query(QueryDetails.FullRow, connection.LocalDataSource, new QueryParameter("ix_supportauth", 2));
			if (list == null || list.Count == 0)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				byte[] dataField = list[i].GetDataField();
				try
				{
					using MemoryStream stream = new MemoryStream(dataField);
					InfoCard infoCard = new InfoCard(stream);
					foreach (TokenCreationParameter creationParameter in infoCard.CreationParameters)
					{
						if (creationParameter.CredentialType == TokenFactoryCredentialType.SelfIssuedCredential)
						{
							string stringWithoutNullTerminator = creationParameter.CredentialSelectors[CredentialSelectorType.SelfIssuedCardIdSelector].GetStringWithoutNullTerminator();
							if (Utility.CompareByteArrays(Convert.FromBase64String(stringWithoutNullTerminator), Utility.CreateHash(infoCard.IssuerIdentifierAsBytes, m_selfIssuedCardId)))
							{
								m_allCards.Add(infoCard);
							}
						}
					}
				}
				finally
				{
					Array.Clear(dataField, 0, dataField.Length);
				}
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
		BinaryWriter binaryWriter = new BinaryWriter(outArgs, Encoding.Unicode);
		if (m_allCards != null)
		{
			binaryWriter.Write(m_allCards.Count);
			{
				foreach (InfoCard allCard in m_allCards)
				{
					Utility.SerializeUri(binaryWriter, allCard.Id);
				}
				return;
			}
		}
		binaryWriter.Write(0);
	}
}
