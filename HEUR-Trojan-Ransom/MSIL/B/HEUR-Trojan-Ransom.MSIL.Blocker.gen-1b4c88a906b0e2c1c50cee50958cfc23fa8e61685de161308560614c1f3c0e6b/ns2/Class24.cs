using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using ns0;
using ns1;
using ns12;
using ns18;
using ns9;

namespace ns2;

internal class Class24 : Class9
{
	private const string string_0 = "Pattern";

	private const string string_1 = "Options";

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		Regex regex_ = (Regex)object_0;
		if (class38_0 is Class42 class42_)
		{
			Class7.smethod_662(regex_, class42_, this);
		}
		else
		{
			Class7.smethod_151(this, class38_0, regex_, class34_0);
		}
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		return class29_0.TokenType switch
		{
			JsonToken.Null => null, 
			JsonToken.String => Class7.smethod_570(this, class29_0), 
			JsonToken.StartObject => Class7.smethod_218(this, class29_0, class34_0), 
			_ => throw Class7.smethod_161(class29_0, "Unexpected token when reading Regex."), 
		};
	}

	public override bool vmethod_2(Type type_0)
	{
		if (type_0.Name == "Regex")
		{
			return Class7.smethod_663(type_0, this);
		}
		return false;
	}
}
