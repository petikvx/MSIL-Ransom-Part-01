using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfocardExtendedInformationCollection : List<InfocardExtendedInformationEntry>
{
	private const int InvalidRow = 0;

	private Uri m_infoCardId;

	private int m_rowId;

	public InfocardExtendedInformationCollection(Uri infoCardId)
	{
		if (null == infoCardId)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("infoCardId");
		}
		m_infoCardId = infoCardId;
	}

	public void Get(StoreConnection con)
	{
		if (con == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("con");
		}
		DataRow dataRow = TryGetRow(con, QueryDetails.FullRow);
		if (dataRow != null)
		{
			Deserialize(new MemoryStream(dataRow.GetDataField()));
			m_rowId = dataRow.LocalId;
		}
	}

	public void Serialize(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write(base.Count);
		for (int i = 0; i < base.Count; i++)
		{
			base[i].Serialize(binaryWriter);
		}
	}

	public void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new BinaryReader(stream, Encoding.Unicode);
		int num = binaryReader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			InfocardExtendedInformationEntry infocardExtendedInformationEntry = new InfocardExtendedInformationEntry();
			infocardExtendedInformationEntry.Deserialize(binaryReader);
			Add(infocardExtendedInformationEntry);
		}
	}

	public void Save(StoreConnection con)
	{
		if (con == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("con");
		}
		DataRow dataRow = TryGetRow(con, QueryDetails.FullHeader);
		if (dataRow == null)
		{
			dataRow = new DataRow();
			dataRow.ObjectType = 4;
			dataRow.GlobalId = Guid.NewGuid();
		}
		dataRow.SetIndexValue("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString()));
		MemoryStream memoryStream = new MemoryStream();
		Serialize(memoryStream);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
		m_rowId = dataRow.LocalId;
	}

	public string GetIssuerInformationElement()
	{
		int num = 0;
		XmlReader xmlReader;
		while (true)
		{
			if (num < base.Count)
			{
				xmlReader = InfoCardSchemas.CreateReader(base[num].GetXml());
				xmlReader.Read();
				if (xmlReader.IsStartElement("IssuerInformation", "http://schemas.xmlsoap.org/ws/2007/01/identity"))
				{
					break;
				}
				xmlReader.Close();
				num++;
				continue;
			}
			return string.Empty;
		}
		xmlReader.Close();
		return base[num].GetXml();
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "null infocard id", new object[0]);
		return con.GetSingleRow(details, new QueryParameter("ix_objecttype", 4), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString())));
	}
}
