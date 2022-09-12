using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ns0;
using ns10;
using ns12;
using ns13;
using ns18;
using ns5;
using ns9;

namespace ns17;

internal class Class23 : Class9
{
	private const string string_0 = "Key";

	private const string string_1 = "Value";

	private static readonly Class111<Type, Class100> class111_0 = new Class111<Type, Class100>((Func<Type, Class100>)Class7.smethod_648);

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		Class100 class100_ = class111_0.method_0(object_0!.GetType());
		DefaultContractResolver defaultContractResolver = class34_0.ContractResolver as DefaultContractResolver;
		class38_0.vmethod_3();
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Key") : "Key");
		class34_0.method_8(class38_0, Class7.smethod_74(class100_, object_0, "Key"), Class7.smethod_289(class100_, "Key"));
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Value") : "Value");
		class34_0.method_8(class38_0, Class7.smethod_74(class100_, object_0, "Value"), Class7.smethod_289(class100_, "Value"));
		class38_0.vmethod_4();
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			if (!Class7.smethod_157(type_0))
			{
				throw Class7.smethod_161(class29_0, "Cannot convert null value to KeyValuePair.");
			}
			return null;
		}
		object obj = null;
		object obj2 = null;
		Class7.smethod_686(class29_0);
		Type gparam_ = (Class7.smethod_157(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0);
		Class100 @class = class111_0.method_0(gparam_);
		Class137 class2 = class34_0.ContractResolver.imethod_0(Class7.smethod_289(@class, "Key"));
		Class137 class3 = class34_0.ContractResolver.imethod_0(Class7.smethod_289(@class, "Value"));
		while (class29_0.TokenType == JsonToken.PropertyName)
		{
			string a = class29_0.Value!.ToString();
			if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
			{
				Class7.smethod_153(bool_0: false, class29_0, class2);
				obj = class34_0.method_5(class29_0, class2.UnderlyingType);
			}
			else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
			{
				Class7.smethod_153(bool_0: false, class29_0, class3);
				obj2 = class34_0.method_5(class29_0, class3.UnderlyingType);
			}
			else
			{
				Class7.smethod_310(class29_0);
			}
			Class7.smethod_686(class29_0);
		}
		return @class.Creator!(obj, obj2);
	}

	public override bool vmethod_2(Type type_0)
	{
		Type type = (Class7.smethod_157(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0);
		if (type.smethod_13() && type.smethod_4())
		{
			return type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
		}
		return false;
	}
}
