using System.Configuration;

namespace System.Runtime.Caching.Configuration;

[ConfigurationCollection(/*Could not decode attribute arguments.*/)]
public sealed class MemoryCacheSettingsCollection : ConfigurationElementCollection
{
	private static ConfigurationPropertyCollection _properties;

	protected override ConfigurationPropertyCollection Properties => _properties;

	public MemoryCacheElement this[int index]
	{
		get
		{
			return (MemoryCacheElement)(object)((ConfigurationElementCollection)this).BaseGet(index);
		}
		set
		{
			if (((ConfigurationElementCollection)this).BaseGet(index) != null)
			{
				((ConfigurationElementCollection)this).BaseRemoveAt(index);
			}
			((ConfigurationElementCollection)this).BaseAdd(index, (ConfigurationElement)(object)value);
		}
	}

	public MemoryCacheElement this[string key] => (MemoryCacheElement)(object)((ConfigurationElementCollection)this).BaseGet((object)key);

	public override ConfigurationElementCollectionType CollectionType => (ConfigurationElementCollectionType)3;

	static MemoryCacheSettingsCollection()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		_properties = new ConfigurationPropertyCollection();
	}

	public int IndexOf(MemoryCacheElement cache)
	{
		return ((ConfigurationElementCollection)this).BaseIndexOf((ConfigurationElement)(object)cache);
	}

	public void Add(MemoryCacheElement cache)
	{
		((ConfigurationElementCollection)this).BaseAdd((ConfigurationElement)(object)cache);
	}

	public void Remove(MemoryCacheElement cache)
	{
		((ConfigurationElementCollection)this).BaseRemove((object)cache.Name);
	}

	public void RemoveAt(int index)
	{
		((ConfigurationElementCollection)this).BaseRemoveAt(index);
	}

	public void Clear()
	{
		((ConfigurationElementCollection)this).BaseClear();
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return (ConfigurationElement)(object)new MemoryCacheElement();
	}

	protected override ConfigurationElement CreateNewElement(string elementName)
	{
		return (ConfigurationElement)(object)new MemoryCacheElement(elementName);
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((MemoryCacheElement)(object)element).Name;
	}
}
