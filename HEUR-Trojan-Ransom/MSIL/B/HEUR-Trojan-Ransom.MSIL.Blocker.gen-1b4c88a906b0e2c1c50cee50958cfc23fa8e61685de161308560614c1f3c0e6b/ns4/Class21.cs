using System;
using Newtonsoft.Json.Serialization;
using ns0;
using ns10;
using ns12;
using ns18;
using ns5;
using ns9;

namespace ns4;

internal class Class21 : Class9
{
	private const string string_0 = "System.Data.EntityKeyMember";

	private const string string_1 = "Key";

	private const string string_2 = "Type";

	private const string string_3 = "Value";

	internal static Class100? class100_0;

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		Class7.smethod_406(object_0!.GetType());
		DefaultContractResolver defaultContractResolver = class34_0.ContractResolver as DefaultContractResolver;
		string text = (string)Class7.smethod_74(class100_0, object_0, "Key");
		object obj = Class7.smethod_74(class100_0, object_0, "Value");
		Type type = obj?.GetType();
		class38_0.vmethod_3();
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Key") : "Key");
		class38_0.vmethod_21(text);
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Type") : "Type");
		class38_0.vmethod_21(type?.FullName);
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Value") : "Value");
		if (type != null)
		{
			if (Class7.smethod_27(obj, type, out string text2))
			{
				class38_0.vmethod_21(text2);
			}
			else
			{
				class38_0.vmethod_58(obj);
			}
		}
		else
		{
			class38_0.vmethod_17();
		}
		class38_0.vmethod_4();
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		Class7.smethod_406(type_0);
		object obj = class100_0!.Creator!();
		Class7.smethod_733(class29_0, "Key");
		Class7.smethod_686(class29_0);
		Class7.smethod_348(class100_0, obj, "Key", (object)class29_0.Value?.ToString());
		Class7.smethod_733(class29_0, "Type");
		Class7.smethod_686(class29_0);
		Type type = Type.GetType(class29_0.Value?.ToString());
		Class7.smethod_733(class29_0, "Value");
		Class7.smethod_686(class29_0);
		Class7.smethod_348(class100_0, obj, "Value", class34_0.method_5(class29_0, type));
		Class7.smethod_686(class29_0);
		return obj;
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0.smethod_16("System.Data.EntityKeyMember", bool_0: false);
	}
}
