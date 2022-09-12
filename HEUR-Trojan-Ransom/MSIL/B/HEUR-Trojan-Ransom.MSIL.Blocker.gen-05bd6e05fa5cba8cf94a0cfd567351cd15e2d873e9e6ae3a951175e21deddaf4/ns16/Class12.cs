using System;
using System.Globalization;
using Newtonsoft.Json;
using ns10;
using ns12;
using ns13;
using ns17;
using ns18;
using ns2;
using ns5;
using ns7;

namespace ns16;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
internal class Class12 : Class9
{
	public override void vmethod_0(Class38 class38_0, object object_0, Class34 class34_0)
	{
		Class240 @class = (Class240)object_0;
		if (class38_0 is Class42 class42_)
		{
			Class4.smethod_66(@class.Value, class42_);
		}
		else
		{
			class38_0.vmethod_56(@class.Value);
		}
	}

	public override object vmethod_1(Class29 class29_0, Type type_0, object object_0, Class34 class34_0)
	{
		if (class29_0.TokenType != JsonToken.Bytes)
		{
			throw new JsonSerializationException("Expected Bytes but got {0}.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		}
		return new Class240((byte[])class29_0.Value);
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0 == typeof(Class240);
	}
}
