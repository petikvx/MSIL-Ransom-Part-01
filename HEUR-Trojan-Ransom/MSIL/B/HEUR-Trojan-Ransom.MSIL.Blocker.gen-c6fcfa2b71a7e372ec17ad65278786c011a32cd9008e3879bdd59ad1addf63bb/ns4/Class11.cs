using System;
using System.Globalization;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns3;
using ns5;
using ns9;

namespace ns4;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
internal class Class11 : Class8
{
	public override void vmethod_0(Class37 class37_0, object object_0, Class33 class33_0)
	{
		Class240 @class = (Class240)object_0;
		if (class37_0 is Class41 class41_)
		{
			Class131.smethod_9(@class.Value, class41_);
		}
		else
		{
			class37_0.vmethod_56(@class.Value);
		}
	}

	public override object vmethod_1(Class28 class28_0, Type type_0, object object_0, Class33 class33_0)
	{
		if (class28_0.TokenType != JsonToken.Bytes)
		{
			throw new JsonSerializationException("Expected Bytes but got {0}.".smethod_1(CultureInfo.InvariantCulture, class28_0.TokenType));
		}
		return new Class240((byte[])class28_0.Value);
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0 == typeof(Class240);
	}
}
