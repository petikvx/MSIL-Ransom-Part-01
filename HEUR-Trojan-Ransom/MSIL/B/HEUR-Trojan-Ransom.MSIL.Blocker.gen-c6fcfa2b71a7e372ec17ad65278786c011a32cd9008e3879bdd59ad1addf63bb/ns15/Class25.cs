using System;
using System.Globalization;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns3;
using ns9;

namespace ns15;

internal class Class25 : Class8
{
	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		if (!(object_0 is Version))
		{
			throw new JsonSerializationException("Expected Version object value");
		}
		class37_0.vmethod_21(object_0!.ToString());
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		if (class28_0.TokenType == JsonToken.String)
		{
			try
			{
				return new Version((string)class28_0.Value);
			}
			catch (Exception exception_)
			{
				throw Class131.smethod_200("Error parsing version string: {0}".smethod_1(CultureInfo.InvariantCulture, class28_0.Value), exception_, class28_0);
			}
		}
		throw Class131.smethod_38(class28_0, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".smethod_2(CultureInfo.InvariantCulture, class28_0.TokenType, class28_0.Value));
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0 == typeof(Version);
	}
}
