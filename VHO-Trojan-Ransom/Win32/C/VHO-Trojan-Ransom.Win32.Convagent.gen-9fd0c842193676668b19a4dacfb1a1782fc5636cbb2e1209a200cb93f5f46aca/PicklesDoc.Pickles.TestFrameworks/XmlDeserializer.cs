using System.IO;
using System.IO.Abstractions;
using System.Xml;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks;

public class XmlDeserializer<TItem> where TItem : class
{
	public TItem Load(FileInfoBase fileInfo)
	{
		using Stream stream = fileInfo.OpenRead();
		return Load(stream);
	}

	public TItem Load(Stream stream)
	{
		using XmlReader xmlReader = XmlReader.Create(stream);
		return (TItem)new XmlSerializer(typeof(TItem)).Deserialize(xmlReader);
	}
}
