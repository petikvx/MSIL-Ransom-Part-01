using System.ComponentModel;
using System.Configuration;

namespace System.Runtime.Caching.Configuration;

public sealed class MemoryCacheElement : ConfigurationElement
{
	private static ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propName;

	private static readonly ConfigurationProperty _propPhysicalMemoryLimitPercentage;

	private static readonly ConfigurationProperty _propCacheMemoryLimitMegabytes;

	private static readonly ConfigurationProperty _propPollingInterval;

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
	[StringValidator(MinLength = 1)]
	[TypeConverter(typeof(WhiteSpaceTrimStringConverter))]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("name");
		}
		set
		{
			((ConfigurationElement)this).set_Item("name", (object)value);
		}
	}

	[ConfigurationProperty("physicalMemoryLimitPercentage", DefaultValue = 0)]
	[IntegerValidator(MinValue = 0, MaxValue = 100)]
	public int PhysicalMemoryLimitPercentage
	{
		get
		{
			return (int)((ConfigurationElement)this).get_Item("physicalMemoryLimitPercentage");
		}
		set
		{
			((ConfigurationElement)this).set_Item("physicalMemoryLimitPercentage", (object)value);
		}
	}

	[ConfigurationProperty("cacheMemoryLimitMegabytes", DefaultValue = 0)]
	[IntegerValidator(MinValue = 0)]
	public int CacheMemoryLimitMegabytes
	{
		get
		{
			return (int)((ConfigurationElement)this).get_Item("cacheMemoryLimitMegabytes");
		}
		set
		{
			((ConfigurationElement)this).set_Item("cacheMemoryLimitMegabytes", (object)value);
		}
	}

	[TypeConverter(typeof(InfiniteTimeSpanConverter))]
	[ConfigurationProperty("pollingInterval", DefaultValue = "00:02:00")]
	public TimeSpan PollingInterval
	{
		get
		{
			return (TimeSpan)((ConfigurationElement)this).get_Item("pollingInterval");
		}
		set
		{
			((ConfigurationElement)this).set_Item("pollingInterval", (object)value);
		}
	}

	static MemoryCacheElement()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b7: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		_properties = new ConfigurationPropertyCollection();
		_propName = new ConfigurationProperty("name", typeof(string), (object)null, (TypeConverter)new WhiteSpaceTrimStringConverter(), (ConfigurationValidatorBase)new StringValidator(1), (ConfigurationPropertyOptions)6);
		_propPhysicalMemoryLimitPercentage = new ConfigurationProperty("physicalMemoryLimitPercentage", typeof(int), (object)0, (TypeConverter)null, (ConfigurationValidatorBase)new IntegerValidator(0, 100), (ConfigurationPropertyOptions)0);
		_propCacheMemoryLimitMegabytes = new ConfigurationProperty("cacheMemoryLimitMegabytes", typeof(int), (object)0, (TypeConverter)null, (ConfigurationValidatorBase)new IntegerValidator(0, int.MaxValue), (ConfigurationPropertyOptions)0);
		_propPollingInterval = new ConfigurationProperty("pollingInterval", typeof(TimeSpan), (object)TimeSpan.FromMilliseconds(120000.0), (TypeConverter)new InfiniteTimeSpanConverter(), (ConfigurationValidatorBase)new PositiveTimeSpanValidator(), (ConfigurationPropertyOptions)0);
		_properties.Add(_propName);
		_properties.Add(_propPhysicalMemoryLimitPercentage);
		_properties.Add(_propCacheMemoryLimitMegabytes);
		_properties.Add(_propPollingInterval);
	}

	internal MemoryCacheElement()
	{
	}

	public MemoryCacheElement(string name)
	{
		Name = name;
	}
}
