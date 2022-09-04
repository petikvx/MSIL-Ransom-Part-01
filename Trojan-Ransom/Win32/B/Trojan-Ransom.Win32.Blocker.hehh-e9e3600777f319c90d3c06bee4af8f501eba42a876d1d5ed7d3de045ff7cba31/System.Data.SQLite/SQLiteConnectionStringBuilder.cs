using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Reflection;

namespace System.Data.SQLite;

[DefaultMember("Item")]
[DefaultProperty("DataSource")]
public sealed class SQLiteConnectionStringBuilder : DbConnectionStringBuilder
{
	private Hashtable _properties;

	[Browsable(true)]
	[DefaultValue(3)]
	public int Version
	{
		get
		{
			TryGetValue("version", out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			if (value != 3)
			{
				throw new NotSupportedException();
			}
			this["version"] = value;
		}
	}

	[DefaultValue(SynchronizationModes.Normal)]
	[DisplayName("Synchronous")]
	[Browsable(true)]
	public SynchronizationModes SyncMode
	{
		get
		{
			TryGetValue("synchronous", out var value);
			if (value is string)
			{
				return (SynchronizationModes)TypeDescriptor.GetConverter(typeof(SynchronizationModes)).ConvertFrom(value);
			}
			return (SynchronizationModes)value;
		}
		set
		{
			this["synchronous"] = value;
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	public bool UseUTF16Encoding
	{
		get
		{
			TryGetValue("useutf16encoding", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["useutf16encoding"] = value;
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	public bool Pooling
	{
		get
		{
			TryGetValue("pooling", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["pooling"] = value;
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	public bool BinaryGUID
	{
		get
		{
			TryGetValue("binaryguid", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["binaryguid"] = value;
		}
	}

	[DefaultValue("")]
	[Browsable(true)]
	[DisplayName("Data Source")]
	public string DataSource
	{
		get
		{
			TryGetValue("data source", out var value);
			return value.ToString();
		}
		set
		{
			this["data source"] = value;
		}
	}

	[Browsable(false)]
	public string Uri
	{
		get
		{
			TryGetValue("uri", out var value);
			return value.ToString();
		}
		set
		{
			this["uri"] = value;
		}
	}

	[DisplayName("Default Timeout")]
	[Browsable(true)]
	[DefaultValue(30)]
	public int DefaultTimeout
	{
		get
		{
			TryGetValue("default timeout", out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this["default timeout"] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	public bool Enlist
	{
		get
		{
			TryGetValue("enlist", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["enlist"] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	public bool FailIfMissing
	{
		get
		{
			TryGetValue("failifmissing", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["failifmissing"] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("Legacy Format")]
	[DefaultValue(false)]
	public bool LegacyFormat
	{
		get
		{
			TryGetValue("legacy format", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["legacy format"] = value;
		}
	}

	[DisplayName("Read Only")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool ReadOnly
	{
		get
		{
			TryGetValue("read only", out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this["read only"] = value;
		}
	}

	[PasswordPropertyText(true)]
	[DefaultValue("")]
	[Browsable(true)]
	public string Password
	{
		get
		{
			TryGetValue("password", out var value);
			return value.ToString();
		}
		set
		{
			this["password"] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(1024)]
	[DisplayName("Page Size")]
	public int PageSize
	{
		get
		{
			TryGetValue("page size", out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this["page size"] = value;
		}
	}

	[DefaultValue(0)]
	[Browsable(true)]
	[DisplayName("Max Page Count")]
	public int MaxPageCount
	{
		get
		{
			TryGetValue("max page count", out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this["max page count"] = value;
		}
	}

	[DisplayName("Cache Size")]
	[Browsable(true)]
	[DefaultValue(2000)]
	public int CacheSize
	{
		get
		{
			TryGetValue("cache size", out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this["cache size"] = value;
		}
	}

	[DefaultValue(SQLiteDateFormats.ISO8601)]
	[Browsable(true)]
	public SQLiteDateFormats DateTimeFormat
	{
		get
		{
			TryGetValue("datetimeformat", out var value);
			if (value is string)
			{
				return (SQLiteDateFormats)TypeDescriptor.GetConverter(typeof(SQLiteDateFormats)).ConvertFrom(value);
			}
			return (SQLiteDateFormats)value;
		}
		set
		{
			this["datetimeformat"] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(SQLiteJournalModeEnum.Delete)]
	[DisplayName("Journal Mode")]
	public SQLiteJournalModeEnum JournalMode
	{
		get
		{
			TryGetValue("journal mode", out var value);
			if (value is string)
			{
				return (SQLiteJournalModeEnum)TypeDescriptor.GetConverter(typeof(SQLiteJournalModeEnum)).ConvertFrom(value);
			}
			return (SQLiteJournalModeEnum)value;
		}
		set
		{
			this["journal mode"] = value;
		}
	}

	[DefaultValue(IsolationLevel.Serializable)]
	[Browsable(true)]
	[DisplayName("Default Isolation Level")]
	public IsolationLevel DefaultIsolationLevel
	{
		get
		{
			TryGetValue("default isolationlevel", out var value);
			if (value is string)
			{
				return (IsolationLevel)TypeDescriptor.GetConverter(typeof(IsolationLevel)).ConvertFrom(value);
			}
			return (IsolationLevel)value;
		}
		set
		{
			this["default isolationlevel"] = value;
		}
	}

	public SQLiteConnectionStringBuilder()
	{
		Initialize(null);
	}

	public SQLiteConnectionStringBuilder(string connectionString)
	{
		Initialize(connectionString);
	}

	private void Initialize(string cnnString)
	{
		_properties = new Hashtable(StringComparer.OrdinalIgnoreCase);
		try
		{
			base.GetProperties(_properties);
		}
		catch (NotImplementedException)
		{
			FallbackGetProperties(_properties);
		}
		if (!string.IsNullOrEmpty(cnnString))
		{
			base.ConnectionString = cnnString;
		}
	}

	public override bool TryGetValue(string keyword, out object value)
	{
		bool flag = base.TryGetValue(keyword, out value);
		if (!_properties.ContainsKey(keyword))
		{
			return flag;
		}
		if (!(_properties[keyword] is PropertyDescriptor propertyDescriptor))
		{
			return flag;
		}
		if (flag)
		{
			if ((object)propertyDescriptor.PropertyType == typeof(bool))
			{
				value = SQLiteConvert.ToBoolean(value);
			}
			else
			{
				value = TypeDescriptor.GetConverter(propertyDescriptor.PropertyType).ConvertFrom(value);
			}
		}
		else if (propertyDescriptor.Attributes[typeof(DefaultValueAttribute)] is DefaultValueAttribute defaultValueAttribute)
		{
			value = defaultValueAttribute.Value;
			flag = true;
		}
		return flag;
	}

	private void FallbackGetProperties(Hashtable propertyList)
	{
		foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(this, noCustomTypeDesc: true))
		{
			if (property.Name != "ConnectionString" && !propertyList.ContainsKey(property.DisplayName))
			{
				propertyList.Add(property.DisplayName, property);
			}
		}
	}
}
