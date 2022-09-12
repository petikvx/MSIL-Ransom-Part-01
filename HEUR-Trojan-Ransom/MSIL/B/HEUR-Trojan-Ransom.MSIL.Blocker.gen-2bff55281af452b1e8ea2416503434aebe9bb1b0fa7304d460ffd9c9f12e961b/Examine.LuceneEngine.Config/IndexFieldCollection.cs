using System.Configuration;

namespace Examine.LuceneEngine.Config;

public sealed class IndexFieldCollection : ConfigurationElementCollection
{
	public IndexField this[string name] => (IndexField)(object)((ConfigurationElementCollection)this).BaseGet((object)name);

	protected override ConfigurationElement CreateNewElement()
	{
		return (ConfigurationElement)(object)new IndexField();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((IndexField)(object)element).Name;
	}

	public override bool IsReadOnly()
	{
		return false;
	}

	public void Add(IndexField field)
	{
		((ConfigurationElementCollection)this).BaseAdd((ConfigurationElement)(object)field, true);
	}
}
