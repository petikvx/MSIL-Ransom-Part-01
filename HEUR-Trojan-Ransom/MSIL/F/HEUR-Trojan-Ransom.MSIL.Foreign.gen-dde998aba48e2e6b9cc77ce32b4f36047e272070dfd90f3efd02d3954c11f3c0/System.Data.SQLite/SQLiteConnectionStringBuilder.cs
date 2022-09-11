using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[DefaultMember("Item")]
[DefaultProperty("DataSource")]
public sealed class SQLiteConnectionStringBuilder : DbConnectionStringBuilder
{
	private Hashtable _properties;

	[NonSerialized]
	internal static GetString _001A;

	[DefaultValue(3)]
	[Browsable(true)]
	public int Version
	{
		get
		{
			TryGetValue(_001A(107352348), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			if (value != 3)
			{
				throw new NotSupportedException();
			}
			this[_001A(107352348)] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("Synchronous")]
	[DefaultValue(SynchronizationModes.Normal)]
	public SynchronizationModes SyncMode
	{
		get
		{
			TryGetValue(_001A(107352303), out var value);
			if (value is string)
			{
				return (SynchronizationModes)TypeDescriptor.GetConverter(typeof(SynchronizationModes)).ConvertFrom(value);
			}
			return (SynchronizationModes)value;
		}
		set
		{
			this[_001A(107352303)] = value;
		}
	}

	[DisplayName("Use UTF-16 Encoding")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool UseUTF16Encoding
	{
		get
		{
			TryGetValue(_001A(107352318), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352318)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	public bool Pooling
	{
		get
		{
			TryGetValue(_001A(107352261), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352261)] = value;
		}
	}

	[DisplayName("Binary GUID")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool BinaryGUID
	{
		get
		{
			TryGetValue(_001A(107352280), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352280)] = value;
		}
	}

	[DefaultValue("")]
	[Browsable(true)]
	[DisplayName("Data Source")]
	public string DataSource
	{
		get
		{
			TryGetValue(_001A(107352231), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107352231)] = value;
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[DisplayName("URI")]
	public string Uri
	{
		get
		{
			TryGetValue(_001A(107352246), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107352246)] = value;
		}
	}

	[DisplayName("Full URI")]
	[DefaultValue(null)]
	[Browsable(true)]
	public string FullUri
	{
		get
		{
			TryGetValue(_001A(107352209), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107352209)] = value;
		}
	}

	[DisplayName("Default Timeout")]
	[Browsable(true)]
	[DefaultValue(30)]
	public int DefaultTimeout
	{
		get
		{
			TryGetValue(_001A(107352196), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352196)] = value;
		}
	}

	[DefaultValue(0)]
	[Browsable(true)]
	[DisplayName("Busy Timeout")]
	public int BusyTimeout
	{
		get
		{
			TryGetValue(_001A(107352175), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352175)] = value;
		}
	}

	[DefaultValue(3)]
	[Browsable(true)]
	[DisplayName("Prepare Retries")]
	public int PrepareRetries
	{
		get
		{
			TryGetValue(_001A(107352190), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352190)] = value;
		}
	}

	[DefaultValue(0)]
	[DisplayName("Progress Ops")]
	[Browsable(true)]
	public int ProgressOps
	{
		get
		{
			TryGetValue(_001A(107352137), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352137)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	public bool Enlist
	{
		get
		{
			TryGetValue(_001A(107352152), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352152)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[DisplayName("Fail If Missing")]
	public bool FailIfMissing
	{
		get
		{
			TryGetValue(_001A(107352623), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352623)] = value;
		}
	}

	[DisplayName("Legacy Format")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool LegacyFormat
	{
		get
		{
			TryGetValue(_001A(107352634), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352634)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[DisplayName("Read Only")]
	public bool ReadOnly
	{
		get
		{
			TryGetValue(_001A(107352581), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107352581)] = value;
		}
	}

	[DefaultValue("")]
	[PasswordPropertyText(true)]
	[Browsable(true)]
	public string Password
	{
		get
		{
			TryGetValue(_001A(107352600), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107352600)] = value;
		}
	}

	[PasswordPropertyText(true)]
	[Browsable(true)]
	[DisplayName("Hexadecimal Password")]
	[DefaultValue(null)]
	public byte[] HexPassword
	{
		get
		{
			if (TryGetValue(_001A(107352555), out var value))
			{
				if (value is string)
				{
					return SQLiteConnection.FromHexString((string)value);
				}
				if (value != null)
				{
					return (byte[])value;
				}
			}
			return null;
		}
		set
		{
			this[_001A(107352555)] = SQLiteConnection.ToHexString(value);
		}
	}

	[DefaultValue(4096)]
	[Browsable(true)]
	[DisplayName("Page Size")]
	public int PageSize
	{
		get
		{
			TryGetValue(_001A(107352570), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352570)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(0)]
	[DisplayName("Maximum Page Count")]
	public int MaxPageCount
	{
		get
		{
			TryGetValue(_001A(107352525), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352525)] = value;
		}
	}

	[DefaultValue(-2000)]
	[DisplayName("Cache Size")]
	[Browsable(true)]
	public int CacheSize
	{
		get
		{
			TryGetValue(_001A(107352536), out var value);
			return Convert.ToInt32(value, CultureInfo.CurrentCulture);
		}
		set
		{
			this[_001A(107352536)] = value;
		}
	}

	[DefaultValue(SQLiteDateFormats.ISO8601)]
	[DisplayName("DateTime Format")]
	[Browsable(true)]
	public SQLiteDateFormats DateTimeFormat
	{
		get
		{
			if (TryGetValue(_001A(107352487), out var value))
			{
				if (value is SQLiteDateFormats)
				{
					return (SQLiteDateFormats)value;
				}
				if (value != null)
				{
					return (SQLiteDateFormats)TypeDescriptor.GetConverter(typeof(SQLiteDateFormats)).ConvertFrom(value);
				}
			}
			return SQLiteDateFormats.ISO8601;
		}
		set
		{
			this[_001A(107352487)] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("DateTime Kind")]
	[DefaultValue(DateTimeKind.Unspecified)]
	public DateTimeKind DateTimeKind
	{
		get
		{
			if (TryGetValue(_001A(107352466), out var value))
			{
				if (value is DateTimeKind)
				{
					return (DateTimeKind)value;
				}
				if (value != null)
				{
					return (DateTimeKind)TypeDescriptor.GetConverter(typeof(DateTimeKind)).ConvertFrom(value);
				}
			}
			return DateTimeKind.Unspecified;
		}
		set
		{
			this[_001A(107352466)] = value;
		}
	}

	[DisplayName("DateTime Format String")]
	[DefaultValue(null)]
	[Browsable(true)]
	public string DateTimeFormatString
	{
		get
		{
			if (TryGetValue(_001A(107352481), out var value))
			{
				if (value is string)
				{
					return (string)value;
				}
				if (value != null)
				{
					return value.ToString();
				}
			}
			return null;
		}
		set
		{
			this[_001A(107352481)] = value;
		}
	}

	[DefaultValue("sqlite_default_schema")]
	[Browsable(true)]
	[DisplayName("Base Schema Name")]
	public string BaseSchemaName
	{
		get
		{
			if (TryGetValue(_001A(107352420), out var value))
			{
				if (value is string)
				{
					return (string)value;
				}
				if (value != null)
				{
					return value.ToString();
				}
			}
			return null;
		}
		set
		{
			this[_001A(107352420)] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("Journal Mode")]
	[DefaultValue(SQLiteJournalModeEnum.Default)]
	public SQLiteJournalModeEnum JournalMode
	{
		get
		{
			TryGetValue(_001A(107352399), out var value);
			if (value is string)
			{
				return (SQLiteJournalModeEnum)TypeDescriptor.GetConverter(typeof(SQLiteJournalModeEnum)).ConvertFrom(value);
			}
			return (SQLiteJournalModeEnum)value;
		}
		set
		{
			this[_001A(107352399)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(IsolationLevel.Serializable)]
	[DisplayName("Default Isolation Level")]
	public IsolationLevel DefaultIsolationLevel
	{
		get
		{
			TryGetValue(_001A(107352414), out var value);
			if (value is string)
			{
				return (IsolationLevel)TypeDescriptor.GetConverter(typeof(IsolationLevel)).ConvertFrom(value);
			}
			return (IsolationLevel)value;
		}
		set
		{
			this[_001A(107352414)] = value;
		}
	}

	[DefaultValue((DbType)(-1))]
	[DisplayName("Default Database Type")]
	[Browsable(true)]
	public DbType DefaultDbType
	{
		get
		{
			if (TryGetValue(_001A(107384637), out var value))
			{
				if (value is string)
				{
					return (DbType)TypeDescriptor.GetConverter(typeof(DbType)).ConvertFrom(value);
				}
				if (value != null)
				{
					return (DbType)value;
				}
			}
			return (DbType)(-1);
		}
		set
		{
			this[_001A(107384637)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[DisplayName("Default Type Name")]
	public string DefaultTypeName
	{
		get
		{
			TryGetValue(_001A(107384584), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107384584)] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("VFS Name")]
	[DefaultValue(null)]
	public string VfsName
	{
		get
		{
			TryGetValue(_001A(107384595), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107384595)] = value;
		}
	}

	[DefaultValue(false)]
	[DisplayName("Foreign Keys")]
	[Browsable(true)]
	public bool ForeignKeys
	{
		get
		{
			TryGetValue(_001A(107384550), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107384550)] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("Recursive Triggers")]
	[DefaultValue(false)]
	public bool RecursiveTriggers
	{
		get
		{
			TryGetValue(_001A(107384565), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107384565)] = value;
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[DisplayName("ZipVFS Version")]
	public string ZipVfsVersion
	{
		get
		{
			TryGetValue(_001A(107384540), out var value);
			return value?.ToString();
		}
		set
		{
			this[_001A(107384540)] = value;
		}
	}

	[DefaultValue(SQLiteConnectionFlags.Default)]
	[Browsable(true)]
	public SQLiteConnectionFlags Flags
	{
		get
		{
			if (TryGetValue(_001A(107384487), out var value))
			{
				if (value is SQLiteConnectionFlags)
				{
					return (SQLiteConnectionFlags)value;
				}
				if (value != null)
				{
					return (SQLiteConnectionFlags)TypeDescriptor.GetConverter(typeof(SQLiteConnectionFlags)).ConvertFrom(value);
				}
			}
			return SQLiteConnectionFlags.Default;
		}
		set
		{
			this[_001A(107384487)] = value;
		}
	}

	[DisplayName("Set Defaults")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool SetDefaults
	{
		get
		{
			TryGetValue(_001A(107384510), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107384510)] = value;
		}
	}

	[Browsable(true)]
	[DisplayName("To Full Path")]
	[DefaultValue(true)]
	public bool ToFullPath
	{
		get
		{
			TryGetValue(_001A(107384461), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107384461)] = value;
		}
	}

	[DisplayName("No Default Flags")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool NoDefaultFlags
	{
		get
		{
			TryGetValue(_001A(107384476), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107384476)] = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[DisplayName("No Shared Flags")]
	public bool NoSharedFlags
	{
		get
		{
			TryGetValue(_001A(107384423), out var value);
			return SQLiteConvert.ToBoolean(value);
		}
		set
		{
			this[_001A(107384423)] = value;
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
			else if ((object)propertyDescriptor.PropertyType != typeof(byte[]))
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
			if (property.Name != _001A(107384402) && !propertyList.ContainsKey(property.DisplayName))
			{
				propertyList.Add(property.DisplayName, property);
			}
		}
	}

	static SQLiteConnectionStringBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteConnectionStringBuilder));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001A(107400884), _001A(107400847)), _001A(107400842), _001A(107400837)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001A(107400864)))
		{
			return;
		}
		throw new SecurityException(_001A(107400807));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
