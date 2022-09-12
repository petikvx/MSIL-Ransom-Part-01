using System.Xml.Linq;

namespace Examine;

public class IndexItem
{
	public XElement DataToIndex { get; private set; }

	public string IndexType { get; private set; }

	public string Id { get; private set; }

	public IndexItem(XElement data, string type, string id)
	{
		DataToIndex = data;
		IndexType = type;
		Id = id;
	}
}
