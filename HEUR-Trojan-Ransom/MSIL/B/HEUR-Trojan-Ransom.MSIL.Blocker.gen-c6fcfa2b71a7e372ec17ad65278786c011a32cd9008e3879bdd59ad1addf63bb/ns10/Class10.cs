using System;
using System.Data.SqlTypes;
using System.Globalization;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns3;
using ns9;

namespace ns10;

internal class Class10 : Class8
{
	private const string string_0 = "System.Data.Linq.Binary";

	private const string string_1 = "ToArray";

	internal static Class99? class99_0;

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		byte[] byte_ = Class131.smethod_26(this, object_0);
		class37_0.vmethod_56(byte_);
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			if (!Class131.smethod_666(type_0))
			{
				throw Class131.smethod_38(class28_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		byte[] array;
		if (class28_0.TokenType == JsonToken.StartArray)
		{
			array = Class131.smethod_152(this, class28_0);
		}
		else
		{
			if (class28_0.TokenType != JsonToken.String)
			{
				throw Class131.smethod_38(class28_0, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".smethod_1(CultureInfo.InvariantCulture, class28_0.TokenType));
			}
			array = Convert.FromBase64String(class28_0.Value!.ToString());
		}
		Type type = (Class131.smethod_175(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0);
		if (type.FullName == "System.Data.Linq.Binary")
		{
			Class131.smethod_126(type);
			return class99_0!.Creator!(array);
		}
		if (!(type == typeof(SqlBinary)))
		{
			throw Class131.smethod_38(class28_0, "Unexpected object type when writing binary: {0}".smethod_1(CultureInfo.InvariantCulture, type_0));
		}
		return new SqlBinary(array);
	}

	public override bool vmethod_2(Type type_0)
	{
		if (type_0.FullName == "System.Data.Linq.Binary")
		{
			return true;
		}
		if (!(type_0 == typeof(SqlBinary)) && !(type_0 == typeof(SqlBinary?)))
		{
			return false;
		}
		return true;
	}
}
