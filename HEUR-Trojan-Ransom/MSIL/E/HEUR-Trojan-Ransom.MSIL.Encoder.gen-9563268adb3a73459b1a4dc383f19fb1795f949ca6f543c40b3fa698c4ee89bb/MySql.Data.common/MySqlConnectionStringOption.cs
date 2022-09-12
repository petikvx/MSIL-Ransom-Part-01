using System;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Reflection;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace MySql.Data.common;

internal class MySqlConnectionStringOption
{
	public delegate void SetterDelegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value);

	public delegate object GetterDelegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender);

	public delegate void ClassicSetterDelegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value);

	public delegate object ClassicGetterDelegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender);

	public delegate void XSetterDelegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value);

	public delegate object XGetterDelegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender);

	public Type BaseType { get; private set; }

	public bool IsCustomized { get; }

	public string[] Synonyms { get; private set; }

	public bool Obsolete { get; private set; }

	public string Keyword { get; private set; }

	public object DefaultValue { get; private set; }

	public SetterDelegate Setter { get; private set; }

	public GetterDelegate Getter { get; private set; }

	public ClassicSetterDelegate ClassicSetter { get; private set; }

	public ClassicGetterDelegate ClassicGetter { get; private set; }

	public XSetterDelegate XSetter { get; private set; }

	public XGetterDelegate XGetter { get; private set; }

	public MySqlConnectionStringOption(string keyword, string synonyms, Type baseType, object defaultValue, bool obsolete, SetterDelegate setter, GetterDelegate getter)
	{
		Keyword = StringUtility.ToLowerInvariant(keyword);
		if (synonyms != null)
		{
			Synonyms = StringUtility.ToLowerInvariant(synonyms).Split(new char[1] { ',' });
		}
		BaseType = baseType;
		Obsolete = obsolete;
		DefaultValue = defaultValue;
		Setter = setter;
		Getter = getter;
		IsCustomized = true;
	}

	public MySqlConnectionStringOption(string keyword, string synonyms, Type baseType, object defaultValue, bool obsolete, ClassicSetterDelegate setter, ClassicGetterDelegate getter)
	{
		Keyword = StringUtility.ToLowerInvariant(keyword);
		if (synonyms != null)
		{
			Synonyms = StringUtility.ToLowerInvariant(synonyms).Split(new char[1] { ',' });
		}
		BaseType = baseType;
		Obsolete = obsolete;
		DefaultValue = defaultValue;
		ClassicSetter = setter;
		ClassicGetter = getter;
		IsCustomized = true;
	}

	public MySqlConnectionStringOption(string keyword, string synonyms, Type baseType, object defaultValue, bool obsolete, XSetterDelegate setter, XGetterDelegate getter)
	{
		Keyword = StringUtility.ToLowerInvariant(keyword);
		if (synonyms != null)
		{
			Synonyms = StringUtility.ToLowerInvariant(synonyms).Split(new char[1] { ',' });
		}
		BaseType = baseType;
		Obsolete = obsolete;
		DefaultValue = defaultValue;
		XSetter = setter;
		XGetter = getter;
		IsCustomized = true;
	}

	public MySqlConnectionStringOption(string keyword, string synonyms, Type baseType, object defaultValue, bool obsolete)
		: this(keyword, synonyms, baseType, defaultValue, obsolete, delegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value)
		{
			sender.ValidateValue(ref value);
			msb.SetInternalValue(sender.Keyword, Convert.ChangeType(value, sender.BaseType));
		}, (MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender) => msb.values[sender.Keyword])
	{
		IsCustomized = false;
	}

	public bool HasKeyword(string key)
	{
		if (Keyword == key)
		{
			return true;
		}
		if (Synonyms == null)
		{
			return false;
		}
		return Synonyms.Any((string syn) => syn == key);
	}

	public void Clean(DbConnectionStringBuilder builder)
	{
		builder.Remove(Keyword);
		if (Synonyms != null)
		{
			string[] synonyms = Synonyms;
			foreach (string keyword in synonyms)
			{
				builder.Remove(keyword);
			}
		}
	}

	public void ValidateValue(ref object value, string keyword = null, bool isXProtocol = false)
	{
		if (value == null)
		{
			return;
		}
		string name = BaseType.Name;
		Type type = value.GetType();
		bool result;
		if (type.Name == "String")
		{
			if (BaseType == type)
			{
				return;
			}
			if (BaseType == typeof(bool))
			{
				if (string.Compare("yes", (string)value, StringComparison.OrdinalIgnoreCase) == 0)
				{
					value = true;
					return;
				}
				if (string.Compare("no", (string)value, StringComparison.OrdinalIgnoreCase) == 0)
				{
					value = false;
					return;
				}
				if (bool.TryParse(value.ToString(), out result))
				{
					value = result;
					return;
				}
				throw new ArgumentException(string.Format(Resources.ValueNotCorrectType, value));
			}
		}
		if (name == "Boolean" && bool.TryParse(value.ToString(), out result))
		{
			value = result;
			return;
		}
		if (name.StartsWith("UInt64") && ulong.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var result2))
		{
			value = result2;
			return;
		}
		if (name.StartsWith("UInt32") && uint.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var result3))
		{
			value = result3;
			return;
		}
		if (name.StartsWith("Int64") && long.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var result4))
		{
			value = result4;
			return;
		}
		if (name.StartsWith("Int32") && int.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var result5))
		{
			value = result5;
			return;
		}
		Type baseType = BaseType.GetTypeInfo().BaseType;
		if (!(baseType != null) || !(baseType.Name == "Enum") || !ParseEnum(value.ToString(), out var value2))
		{
			if (!string.IsNullOrEmpty(keyword) && isXProtocol && keyword != null && keyword == "compression")
			{
				throw new ArgumentException(string.Format(ResourcesX.CompressionInvalidValue, value));
			}
			throw new ArgumentException(string.Format(Resources.ValueNotCorrectType, value));
		}
		value = value2;
	}

	public void ValidateValue(ref object value, string keyword)
	{
		string name = BaseType.Name;
		Type type = value.GetType();
		if (keyword != null && keyword == "connect-timeout" && name != type.Name && !uint.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var _))
		{
			throw new FormatException(ResourcesX.InvalidConnectionTimeoutValue);
		}
	}

	private bool ParseEnum(string requestedValue, out object value)
	{
		value = null;
		try
		{
			value = Enum.Parse(BaseType, requestedValue, ignoreCase: true);
			if (value != null && Enum.IsDefined(BaseType, value.ToString()))
			{
				return true;
			}
			value = null;
			return false;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}
}
