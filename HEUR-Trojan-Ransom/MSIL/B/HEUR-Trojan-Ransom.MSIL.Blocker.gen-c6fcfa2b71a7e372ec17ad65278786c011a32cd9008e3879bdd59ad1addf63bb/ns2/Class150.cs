using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns13;
using ns17;
using ns3;
using ns4;

namespace ns2;

internal class Class150 : KeyedCollection<string, JsonProperty>
{
	private readonly Type type_0;

	internal readonly List<JsonProperty> list_0;

	public Class150(Type type_1)
		: base((IEqualityComparer<string>?)StringComparer.Ordinal)
	{
		Class112.smethod_0(type_1, "type");
		type_0 = type_1;
		list_0 = (List<JsonProperty>)base.Items;
	}

	string KeyedCollection<string, JsonProperty>.GetKeyForItem(JsonProperty item)
	{
		return item.string_0;
	}

	public void method_0(JsonProperty jsonProperty_0)
	{
		if (Contains(jsonProperty_0.string_0))
		{
			if (jsonProperty_0.Ignored)
			{
				return;
			}
			JsonProperty jsonProperty = base[jsonProperty_0.string_0];
			bool flag = true;
			if (jsonProperty.Ignored)
			{
				Remove(jsonProperty);
				flag = false;
			}
			else if (jsonProperty_0.DeclaringType != null && jsonProperty.DeclaringType != null)
			{
				if (jsonProperty_0.DeclaringType!.IsSubclassOf(jsonProperty.DeclaringType) || (jsonProperty.DeclaringType.smethod_3() && jsonProperty_0.DeclaringType.smethod_17(jsonProperty.DeclaringType)))
				{
					Remove(jsonProperty);
					flag = false;
				}
				if (jsonProperty.DeclaringType!.IsSubclassOf(jsonProperty_0.DeclaringType) || (jsonProperty_0.DeclaringType.smethod_3() && jsonProperty.DeclaringType.smethod_17(jsonProperty_0.DeclaringType)) || (type_0.smethod_17(jsonProperty.DeclaringType) && type_0.smethod_17(jsonProperty_0.DeclaringType)))
				{
					return;
				}
			}
			if (flag)
			{
				throw new JsonSerializationException("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.string_0, type_0));
			}
		}
		Add(jsonProperty_0);
	}

	internal bool method_1(string string_0, [Attribute1(true)] out JsonProperty? jsonProperty_0)
	{
		if (base.Dictionary == null)
		{
			jsonProperty_0 = null;
			return false;
		}
		return base.Dictionary!.TryGetValue(string_0, out jsonProperty_0);
	}
}
