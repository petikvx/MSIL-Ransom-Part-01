using System;
using Newtonsoft.Json.Serialization;
using ns1;
using ns13;
using ns3;
using ns9;

namespace ns17;

internal class Class20 : Class8
{
	private const string string_0 = "System.Data.EntityKeyMember";

	private const string string_1 = "Key";

	private const string string_2 = "Type";

	private const string string_3 = "Value";

	internal static Class99? class99_0;

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		Class131.smethod_18(object_0!.GetType());
		DefaultContractResolver defaultContractResolver = class33_0.ContractResolver as DefaultContractResolver;
		string text = (string)Class131.smethod_418(class99_0, object_0, "Key");
		object obj = Class131.smethod_418(class99_0, object_0, "Value");
		Type type = obj?.GetType();
		class37_0.vmethod_3();
		class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Key") : "Key");
		class37_0.vmethod_21(text);
		class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Type") : "Type");
		class37_0.vmethod_21(type?.FullName);
		class37_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Value") : "Value");
		if (type != null)
		{
			if (Class131.smethod_90(obj, type, out string text2))
			{
				class37_0.vmethod_21(text2);
			}
			else
			{
				class37_0.vmethod_58(obj);
			}
		}
		else
		{
			class37_0.vmethod_17();
		}
		class37_0.vmethod_4();
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		Class131.smethod_18(type_0);
		object obj = class99_0!.Creator!();
		Class131.smethod_281(class28_0, "Key");
		Class131.smethod_167(class28_0);
		Class131.smethod_478(class99_0, obj, "Key", (object)class28_0.Value?.ToString());
		Class131.smethod_281(class28_0, "Type");
		Class131.smethod_167(class28_0);
		Type type = Type.GetType(class28_0.Value?.ToString());
		Class131.smethod_281(class28_0, "Value");
		Class131.smethod_167(class28_0);
		Class131.smethod_478(class99_0, obj, "Value", class33_0.method_5(class28_0, type));
		Class131.smethod_167(class28_0);
		return obj;
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0.smethod_16("System.Data.EntityKeyMember", bool_0: false);
	}
}
