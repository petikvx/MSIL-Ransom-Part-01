using System.Xml.Linq;

namespace Examine;

public interface IIndexer
{
	IIndexCriteria IndexerData { get; set; }

	void ReIndexNode(XElement node, string type);

	void DeleteFromIndex(string nodeId);

	void IndexAll(string type);

	void RebuildIndex();

	bool IndexExists();
}
