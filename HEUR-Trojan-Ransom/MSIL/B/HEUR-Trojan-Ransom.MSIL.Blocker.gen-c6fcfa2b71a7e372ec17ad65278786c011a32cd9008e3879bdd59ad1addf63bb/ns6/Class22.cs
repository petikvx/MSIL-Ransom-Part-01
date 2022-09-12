using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns1;
using ns13;
using ns17;
using ns3;
using ns4;
using ns9;

namespace ns6;

internal class Class22 : Class8
{
	private const string string_0 = "Key";

	private const string string_1 = "Value";

	private static readonly Class110<Type, Class99> class110_0 = new Class110<Type, Class99>((Func<Type, Class99>)Class131.smethod_462);

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		Class99 class99_ = class110_0.method_0(object_0!.GetType());
		DefaultContractResolver defaultContractResolver = class33_0.ContractResolver as DefaultContractResolver;
		class37_0.vmethod_3();
		class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Key") : "Key");
		class33_0.method_8(class37_0, Class131.smethod_418(class99_, object_0, "Key"), Class131.smethod_5("Key", class99_));
		class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Value") : "Value");
		class33_0.method_8(class37_0, Class131.smethod_418(class99_, object_0, "Value"), Class131.smethod_5("Value", class99_));
		class37_0.vmethod_4();
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			if (!Class131.smethod_175(type_0))
			{
				throw Class131.smethod_38(class28_0, "Cannot convert null value to KeyValuePair.");
			}
			return null;
		}
		object obj = null;
		object obj2 = null;
		Class131.smethod_167(class28_0);
		Type gparam_ = (Class131.smethod_175(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0);
		Class99 @class = class110_0.method_0(gparam_);
		Class137 class2 = class33_0.ContractResolver.imethod_0(Class131.smethod_5("Key", @class));
		Class137 class3 = class33_0.ContractResolver.imethod_0(Class131.smethod_5("Value", @class));
		while (class28_0.TokenType == JsonToken.PropertyName)
		{
			string a = class28_0.Value!.ToString();
			if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
			{
				Class131.smethod_98(bool_0: false, class2, class28_0);
				obj = class33_0.method_5(class28_0, class2.UnderlyingType);
			}
			else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
			{
				Class131.smethod_98(bool_0: false, class3, class28_0);
				obj2 = class33_0.method_5(class28_0, class3.UnderlyingType);
			}
			else
			{
				Class131.smethod_482(class28_0);
			}
			Class131.smethod_167(class28_0);
		}
		return @class.Creator!(obj, obj2);
	}

	public override bool vmethod_2(Type type_0)
	{
		Type type = (Class131.smethod_175(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0);
		if (type.smethod_13() && type.smethod_4())
		{
			return type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
		}
		return false;
	}
}
