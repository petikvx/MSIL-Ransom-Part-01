using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RPIdentityRequirement
{
	private const int InvalidRow = 0;

	private Uri m_infoCardId;

	private int m_rowId;

	private bool m_RPIdentityRequirement;

	public bool StrongIdentityRequired
	{
		get
		{
			return m_RPIdentityRequirement;
		}
		set
		{
			m_RPIdentityRequirement = value;
		}
	}

	private RPIdentityRequirement()
	{
	}

	public RPIdentityRequirement(Uri infoCardId, bool RPIdentityRequirement)
		: this()
	{
		if (null == infoCardId)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("infoCardId");
		}
		m_infoCardId = infoCardId;
		m_RPIdentityRequirement = RPIdentityRequirement;
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
		binaryWriter.Write(m_RPIdentityRequirement);
	}

	public void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		m_RPIdentityRequirement = binaryReader.ReadBoolean();
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
			dataRow.ObjectType = 5;
			dataRow.GlobalId = Guid.NewGuid();
		}
		dataRow.SetIndexValue("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString()));
		MemoryStream memoryStream = new MemoryStream();
		Serialize(memoryStream);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
		m_rowId = dataRow.LocalId;
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "null infocard id", new object[0]);
		return con.GetSingleRow(details, new QueryParameter("ix_objecttype", 5), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString())));
	}
}
