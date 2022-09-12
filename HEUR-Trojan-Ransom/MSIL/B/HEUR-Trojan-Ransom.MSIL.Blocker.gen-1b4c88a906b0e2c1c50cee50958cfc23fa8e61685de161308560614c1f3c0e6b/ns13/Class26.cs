using System;
using System.Globalization;
using Newtonsoft.Json;
using ns0;
using ns10;
using ns12;
using ns18;
using ns9;

namespace ns13;

internal class Class26 : Class9
{
	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		if (!(object_0 is Version))
		{
			throw new JsonSerializationException("Expected Version object value");
		}
		class38_0.vmethod_21(object_0!.ToString());
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		if (class29_0.TokenType == JsonToken.String)
		{
			try
			{
				return new Version((string)class29_0.Value);
			}
			catch (Exception exception_)
			{
				throw Class7.smethod_383("Error parsing version string: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.Value), exception_, class29_0);
			}
		}
		throw Class7.smethod_161(class29_0, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".smethod_2(CultureInfo.InvariantCulture, class29_0.TokenType, class29_0.Value));
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0 == typeof(Version);
	}
}
