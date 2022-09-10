using System.Collections.Generic;
using System.IO;

namespace Microsoft.InfoCards;

internal class DisplayClaim
{
	private string m_name;

	private List<string> m_value;

	private string m_description;

	private string m_uri;

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public string Id => m_uri;

	public DisplayClaim(BinaryReader reader)
	{
		Deserialize(reader);
	}

	public DisplayClaim(string name, List<string> value, string description, string uri)
	{
		m_name = name;
		m_value = value;
		m_description = description;
		m_uri = uri;
	}

	public void Serialize(BinaryWriter writer)
	{
		Utility.SerializeString(writer, m_name);
		writer.Write((uint)m_value.Count);
		foreach (string item in m_value)
		{
			Utility.SerializeString(writer, item);
		}
		Utility.SerializeString(writer, m_description);
		Utility.SerializeString(writer, m_uri);
	}

	public void Deserialize(BinaryReader reader)
	{
		m_name = Utility.DeserializeString(reader);
		uint num = reader.ReadUInt32();
		for (uint num2 = 0u; num2 < num; num2++)
		{
			m_value.Add(Utility.DeserializeString(reader));
		}
		m_description = Utility.DeserializeString(reader);
		m_uri = Utility.DeserializeString(reader);
	}
}
