using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns3;
using ns5;
using ns9;

namespace ns17;

internal class Class23 : Class8
{
	private const string string_0 = "Pattern";

	private const string string_1 = "Options";

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		Regex regex_ = (Regex)object_0;
		if (class37_0 is Class41 class41_)
		{
			Class131.smethod_643(regex_, this, class41_);
		}
		else
		{
			Class131.smethod_469(this, class37_0, regex_, class33_0);
		}
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		return class28_0.TokenType switch
		{
			JsonToken.Null => null, 
			JsonToken.String => Class131.smethod_185(this, class28_0), 
			JsonToken.StartObject => Class131.smethod_307(this, class28_0, class33_0), 
			_ => throw Class131.smethod_38(class28_0, "Unexpected token when reading Regex."), 
		};
	}

	public override bool vmethod_2(Type type_0)
	{
		if (type_0.Name == "Regex")
		{
			return Class131.smethod_205(this, type_0);
		}
		return false;
	}
}
