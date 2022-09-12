using System.Xml;

namespace NChanges;

public class ParameterInfo
{
	public string Name { get; set; }

	public string Type { get; set; }

	public ParameterInfo Clone()
	{
		return (ParameterInfo)MemberwiseClone();
	}

	public void WriteXml(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("param");
		xmlWriter.WriteAttributeString("name", Name);
		xmlWriter.WriteAttributeString("type", Type);
		xmlWriter.WriteEndElement();
	}

	public void ReadXml(XmlReader xmlReader)
	{
		Name = xmlReader.GetAttribute("name");
		Type = xmlReader.GetAttribute("type");
	}
}
