using System;
using System.Data.SqlTypes;
using System.Globalization;
using Newtonsoft.Json;
using ns0;
using ns10;
using ns12;
using ns18;
using ns5;
using ns9;

namespace ns14;

internal class Class11 : Class9
{
	private const string string_0 = "System.Data.Linq.Binary";

	private const string string_1 = "ToArray";

	internal static Class100? class100_0;

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		byte[] byte_ = Class7.smethod_263(this, object_0);
		class38_0.vmethod_56(byte_);
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			if (!Class7.smethod_213(type_0))
			{
				throw Class7.smethod_161(class29_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		byte[] array;
		if (class29_0.TokenType == JsonToken.StartArray)
		{
			array = Class7.smethod_160(class29_0, this);
		}
		else
		{
			if (class29_0.TokenType != JsonToken.String)
			{
				throw Class7.smethod_161(class29_0, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
			}
			array = Convert.FromBase64String(class29_0.Value!.ToString());
		}
		Type type = (Class7.smethod_157(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0);
		if (type.FullName == "System.Data.Linq.Binary")
		{
			Class7.smethod_719(type);
			return class100_0!.Creator!(array);
		}
		if (!(type == typeof(SqlBinary)))
		{
			throw Class7.smethod_161(class29_0, "Unexpected object type when writing binary: {0}".smethod_1(CultureInfo.InvariantCulture, type_0));
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
