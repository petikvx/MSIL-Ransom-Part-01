using System;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using ns10;
using ns5;

namespace ns6;

internal class Class149 : IFormatterConverter
{
	private readonly JsonSerializerInternalReader jsonSerializerInternalReader_0;

	private readonly Class142 class142_0;

	private readonly JsonProperty? jsonProperty_0;

	public Class149(JsonSerializerInternalReader jsonSerializerInternalReader_1, Class142 class142_1, JsonProperty? jsonProperty_1)
	{
		Class113.smethod_0(jsonSerializerInternalReader_1, "reader");
		Class113.smethod_0(class142_1, "contract");
		jsonSerializerInternalReader_0 = jsonSerializerInternalReader_1;
		class142_0 = class142_1;
		jsonProperty_0 = jsonProperty_1;
	}

	private T method_0<T>(object object_0)
	{
		Class113.smethod_0(object_0, "value");
		return (T)Convert.ChangeType(((Class179)object_0).Value, typeof(T), CultureInfo.InvariantCulture);
	}

	object? IFormatterConverter.Convert(object value, Type type)
	{
		Class113.smethod_0(value, "value");
		if (!(value is JToken jtoken_))
		{
			throw new ArgumentException("Value is not a JToken.", "value");
		}
		return Class4.smethod_40(jsonSerializerInternalReader_0, jtoken_, type, class142_0, jsonProperty_0);
	}

	object IFormatterConverter.Convert(object value, TypeCode typeCode)
	{
		Class113.smethod_0(value, "value");
		return Convert.ChangeType((value is Class179 @class) ? @class.Value : value, typeCode, CultureInfo.InvariantCulture);
	}

	bool IFormatterConverter.ToBoolean(object value)
	{
		return method_0<bool>(value);
	}

	byte IFormatterConverter.ToByte(object value)
	{
		return method_0<byte>(value);
	}

	char IFormatterConverter.ToChar(object value)
	{
		return method_0<char>(value);
	}

	DateTime IFormatterConverter.ToDateTime(object value)
	{
		return method_0<DateTime>(value);
	}

	decimal IFormatterConverter.ToDecimal(object value)
	{
		return method_0<decimal>(value);
	}

	double IFormatterConverter.ToDouble(object value)
	{
		return method_0<double>(value);
	}

	short IFormatterConverter.ToInt16(object value)
	{
		return method_0<short>(value);
	}

	int IFormatterConverter.ToInt32(object value)
	{
		return method_0<int>(value);
	}

	long IFormatterConverter.ToInt64(object value)
	{
		return method_0<long>(value);
	}

	sbyte IFormatterConverter.ToSByte(object value)
	{
		return method_0<sbyte>(value);
	}

	float IFormatterConverter.ToSingle(object value)
	{
		return method_0<float>(value);
	}

	string IFormatterConverter.ToString(object value)
	{
		return method_0<string>(value);
	}

	ushort IFormatterConverter.ToUInt16(object value)
	{
		return method_0<ushort>(value);
	}

	uint IFormatterConverter.ToUInt32(object value)
	{
		return method_0<uint>(value);
	}

	ulong IFormatterConverter.ToUInt64(object value)
	{
		return method_0<ulong>(value);
	}
}
