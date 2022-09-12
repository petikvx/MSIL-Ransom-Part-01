using System;
using System.Linq;
using System.Reflection;
using MySql.Data.Common;
using MySqlX.XDevAPI;

namespace MySql.Data.MySqlClient;

internal class MySqlConnectionStringOption
{
	public delegate void BaseSetterDelegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value);

	public delegate object BaseGetterDelegate(MySqlBaseConnectionStringBuilder msb, MySqlConnectionStringOption sender);

	public delegate void SetterDelegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value);

	public delegate object GetterDelegate(MySqlConnectionStringBuilder msb, MySqlConnectionStringOption sender);

	public delegate void XSetterDelegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object value);

	public delegate object XGetterDelegate(MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender);

	public bool IsCustomized { get; }

	public string[] Synonyms { get; private set; }

	public bool Obsolete { get; private set; }

	public Type BaseType { get; private set; }

	public string Keyword { get; private set; }

	public object DefaultValue { get; private set; }

	public BaseSetterDelegate BaseSetter { get; private set; }

	public BaseGetterDelegate BaseGetter { get; private set; }

	public SetterDelegate Setter { get; private set; }

	public GetterDelegate Getter { get; private set; }

	public XSetterDelegate XSetter { get; private set; }

	public XGetterDelegate XGetter { get; private set; }

	public MySqlConnectionStringOption(string keyword, string synonyms, Type baseType, object defaultValue, bool obsolete, BaseSetterDelegate setter, BaseGetterDelegate getter)
	{
		Keyword = StringUtility.ToLowerInvariant(keyword);
		if (synonyms != null)
		{
			Synonyms = StringUtility.ToLowerInvariant(synonyms).Split(new char[1] { ',' });
		}
		BaseType = baseType;
		Obsolete = obsolete;
		DefaultValue = defaultValue;
		BaseSetter = setter;
		BaseGetter = getter;
		IsCustomized = true;
	}

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

	public void Clean(MySqlBaseConnectionStringBuilder builder)
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

	public void ValidateValue(ref object value)
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
		if (name.StartsWith("UInt64") && ulong.TryParse(value.ToString(), out var result2))
		{
			value = result2;
			return;
		}
		if (name.StartsWith("UInt32") && uint.TryParse(value.ToString(), out var result3))
		{
			value = result3;
			return;
		}
		if (name.StartsWith("Int64") && long.TryParse(value.ToString(), out var result4))
		{
			value = result4;
			return;
		}
		if (name.StartsWith("Int32") && int.TryParse(value.ToString(), out var result5))
		{
			value = result5;
			return;
		}
		Type baseType = BaseType.GetTypeInfo().BaseType;
		if (!(baseType != null) || !(baseType.Name == "Enum") || !ParseEnum(value.ToString(), out var value2))
		{
			throw new ArgumentException(string.Format(Resources.ValueNotCorrectType, value));
		}
		value = value2;
	}

	public void ValidateValue(ref object value, string keyword)
	{
		string name = BaseType.Name;
		Type type = value.GetType();
		if (keyword == "connect-timeout" && name != type.Name && !uint.TryParse(value.ToString(), out var _))
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
			return true;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}
}
