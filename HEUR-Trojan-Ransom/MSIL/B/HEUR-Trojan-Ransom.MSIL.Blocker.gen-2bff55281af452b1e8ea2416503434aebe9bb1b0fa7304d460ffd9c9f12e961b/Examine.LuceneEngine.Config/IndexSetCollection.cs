using System.Configuration;

namespace Examine.LuceneEngine.Config;

public sealed class IndexSetCollection : ConfigurationElementCollection
{
	public override ConfigurationElementCollectionType CollectionType => (ConfigurationElementCollectionType)0;

	protected override string ElementName => "IndexSet";

	public IndexSet this[string setName] => (IndexSet)(object)((ConfigurationElementCollection)this).BaseGet((object)setName);

	protected override ConfigurationElement CreateNewElement()
	{
		return (ConfigurationElement)(object)new IndexSet();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((IndexSet)(object)element).SetName;
	}
}
