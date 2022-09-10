using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class UserPreference
{
	private const byte Version = 1;

	private const byte Marker = 29;

	private const string Id = "urn:microsoft.com:infocards:user_prefs";

	private const int s_ATApplicationsDisabled = 0;

	private int m_ATApplicationsFlags;

	private bool m_showClaimsFlag;

	public UserPreference()
	{
	}

	public UserPreference(Stream stream)
	{
		Deserialize(stream);
	}

	public void Serialize(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write((byte)1);
		binaryWriter.Write(m_ATApplicationsFlags);
		binaryWriter.Write(m_showClaimsFlag);
		binaryWriter.Write((byte)29);
	}

	public void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		if (1 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "Incorrect version found in stream deserialization", new object[0]);
		}
		m_ATApplicationsFlags = binaryReader.ReadInt32();
		m_showClaimsFlag = binaryReader.ReadBoolean();
		if (29 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "malformed stream detected", new object[0]);
		}
	}

	public void Save(StoreConnection con)
	{
		DataRow dataRow = con.GetSingleRow(new QueryParameter("ix_objecttype", -2), new QueryParameter("ix_globalid", GlobalId.DeriveFrom("urn:microsoft.com:infocards:user_prefs")));
		if (dataRow == null)
		{
			dataRow = new DataRow();
			dataRow.ObjectType = -2;
			dataRow.GlobalId = GlobalId.DeriveFrom("urn:microsoft.com:infocards:user_prefs");
		}
		MemoryStream memoryStream = new MemoryStream();
		Serialize(memoryStream);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("Background Color:\t{0}\n", m_ATApplicationsFlags.ToString(CultureInfo.InvariantCulture));
		stringBuilder.AppendFormat("List expansion flag:\t{0}\n", m_showClaimsFlag.ToString());
		return stringBuilder.ToString();
	}

	public static UserPreference Get(StoreConnection con)
	{
		List<QueryParameter> list = new List<QueryParameter>();
		QueryParameter item = new QueryParameter("ix_objecttype", -2);
		list.Add(item);
		DataRow singleRow = con.GetSingleRow(list.ToArray());
		if (singleRow != null)
		{
			MemoryStream stream = new MemoryStream(singleRow.GetDataField());
			return new UserPreference(stream);
		}
		return null;
	}
}
