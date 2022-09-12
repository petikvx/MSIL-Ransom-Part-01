using System;
using System.Xml;

namespace NChanges;

public class TypeChangeInfo
{
	public TypeChangeKind Kind { get; set; }

	public string Version { get; set; }

	public TypeChangeInfo Clone()
	{
		return (TypeChangeInfo)MemberwiseClone();
	}

	public void WriteXml(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("change");
		xmlWriter.WriteAttributeString("kind", Kind.ToString());
		xmlWriter.WriteAttributeString("version", Version);
		xmlWriter.WriteEndElement();
	}

	public void ReadXml(XmlReader xmlReader)
	{
		Kind = (TypeChangeKind)Enum.Parse(typeof(TypeChangeKind), xmlReader.GetAttribute("kind"));
		Version = xmlReader.GetAttribute("version");
	}
}
