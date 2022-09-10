using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfocardExtendedInformationEntry : IXmlSerializable
{
	private string m_xmlElement;

	public void Serialize(BinaryWriter writer)
	{
		Utility.SerializeString(writer, m_xmlElement);
	}

	public void Deserialize(BinaryReader reader)
	{
		m_xmlElement = Utility.DeserializeString(reader);
	}

	public string GetXml()
	{
		return m_xmlElement;
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void WriteXml(XmlWriter writer)
	{
		if (writer == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("writer");
		}
		XmlReader reader = InfoCardSchemas.CreateReader(m_xmlElement);
		writer.WriteNode(reader, defattr: false);
	}

	public void ReadXml(XmlReader reader)
	{
		if (!reader.IsStartElement())
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		XmlReader xmlReader = reader.ReadSubtree();
		xmlReader.Read();
		m_xmlElement = xmlReader.ReadOuterXml();
		xmlReader.Close();
	}
}
