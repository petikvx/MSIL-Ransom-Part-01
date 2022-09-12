using System;
using System.ComponentModel;
using Newtonsoft.Json.Linq;
using ns15;

namespace ns1;

internal class Class191 : PropertyDescriptor
{
	Type PropertyDescriptor.ComponentType => typeof(JObject);

	bool PropertyDescriptor.IsReadOnly => false;

	Type PropertyDescriptor.PropertyType => typeof(object);

	int MemberDescriptor.NameHashCode => base.NameHashCode;

	public Class191(string string_0)
		: base(string_0, null)
	{
	}

	bool PropertyDescriptor.CanResetValue(object component)
	{
		return false;
	}

	object? PropertyDescriptor.GetValue(object component)
	{
		return (component as JObject)?[Name];
	}

	void PropertyDescriptor.ResetValue(object component)
	{
	}

	void PropertyDescriptor.SetValue(object component, object value)
	{
		if (component is JObject jObject)
		{
			JToken value2 = (value as JToken) ?? new Class179(value);
			jObject[Name] = value2;
		}
	}

	bool PropertyDescriptor.ShouldSerializeValue(object component)
	{
		return false;
	}
}
