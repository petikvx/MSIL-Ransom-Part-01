using System;
using System.Globalization;
using Newtonsoft.Json;
using ns10;
using ns17;
using ns18;
using ns2;
using ns4;
using ns5;

namespace ns7;

internal class Class18 : Class16
{
	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		long long_;
		if (object_0 is DateTime dateTime)
		{
			long_ = Class4.smethod_152(dateTime.ToUniversalTime());
		}
		else
		{
			if (!(object_0 is DateTimeOffset dateTimeOffset))
			{
				throw new JsonSerializationException("Expected date object value.");
			}
			long_ = Class4.smethod_152(dateTimeOffset.ToUniversalTime().UtcDateTime);
		}
		class38_0.vmethod_7("Date");
		class38_0.vmethod_24(long_);
		class38_0.vmethod_8();
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			if (!Class4.smethod_753(type_0))
			{
				throw Class4.smethod_777(class29_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		if (class29_0.TokenType == JsonToken.StartConstructor && string.Equals(class29_0.Value?.ToString(), "Date", StringComparison.Ordinal))
		{
			if (!Class4.smethod_408(class29_0, out DateTime dateTime_, out string string_))
			{
				throw Class4.smethod_777(class29_0, string_);
			}
			if ((Class4.smethod_92(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0) == typeof(DateTimeOffset))
			{
				return new DateTimeOffset(dateTime_);
			}
			return dateTime_;
		}
		throw Class4.smethod_777(class29_0, "Unexpected token or value when parsing date. Token: {0}, Value: {1}".smethod_2(CultureInfo.InvariantCulture, class29_0.TokenType, class29_0.Value));
	}
}
