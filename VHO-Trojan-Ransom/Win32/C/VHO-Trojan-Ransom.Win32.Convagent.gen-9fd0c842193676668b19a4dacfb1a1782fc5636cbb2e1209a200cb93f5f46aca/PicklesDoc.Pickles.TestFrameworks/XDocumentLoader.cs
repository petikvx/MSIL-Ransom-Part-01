using System.IO;
using System.IO.Abstractions;
using System.Xml;
using System.Xml.Linq;

namespace PicklesDoc.Pickles.TestFrameworks;

public class XDocumentLoader
{
	public XDocument Load(FileInfoBase fileInfo)
	{
		using Stream stream = fileInfo.OpenRead();
		return Load(stream);
	}

	public XDocument Load(Stream stream)
	{
		return XDocument.Load(XmlReader.Create(stream));
	}
}
