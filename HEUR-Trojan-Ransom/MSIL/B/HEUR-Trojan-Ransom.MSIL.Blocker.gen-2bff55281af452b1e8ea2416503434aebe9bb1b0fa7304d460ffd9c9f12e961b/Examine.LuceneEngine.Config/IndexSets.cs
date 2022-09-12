using System.Configuration;

namespace Examine.LuceneEngine.Config;

public class IndexSets : ConfigurationSection
{
	private static readonly IndexSets m_IndexSets;

	private const string SectionName = "ExamineLuceneIndexSets";

	public static IndexSets Instance => m_IndexSets;

	[ConfigurationProperty("", IsDefaultCollection = true, IsRequired = true)]
	[ConfigurationCollection(typeof(IndexSetCollection))]
	public IndexSetCollection Sets => (IndexSetCollection)((ConfigurationElement)this).get_Item("");

	protected IndexSets()
	{
	}

	static IndexSets()
	{
		m_IndexSets = ConfigurationManager.GetSection("ExamineLuceneIndexSets") as IndexSets;
	}
}
