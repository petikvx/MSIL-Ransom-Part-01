using System;
using System.Globalization;
using Newtonsoft.Json;
using ns13;
using ns3;
using ns6;
using ns9;

namespace ns8;

internal class Class17 : Class15
{
	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		long long_;
		if (object_0 is DateTime dateTime)
		{
			long_ = Class131.smethod_700(dateTime.ToUniversalTime());
		}
		else
		{
			if (!(object_0 is DateTimeOffset dateTimeOffset))
			{
				throw new JsonSerializationException("Expected date object value.");
			}
			long_ = Class131.smethod_700(dateTimeOffset.ToUniversalTime().UtcDateTime);
		}
		class37_0.vmethod_7("Date");
		class37_0.vmethod_24(long_);
		class37_0.vmethod_8();
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
		if (class28_0.TokenType == JsonToken.StartConstructor && string.Equals(class28_0.Value?.ToString(), "Date", StringComparison.Ordinal))
		{
			if (!Class131.smethod_499(class28_0, out DateTime dateTime_, out string string_))
			{
				throw Class131.smethod_38(class28_0, string_);
			}
			if ((Class131.smethod_175(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0) == typeof(DateTimeOffset))
			{
				return new DateTimeOffset(dateTime_);
			}
			return dateTime_;
		}
		throw Class131.smethod_38(class28_0, "Unexpected token or value when parsing date. Token: {0}, Value: {1}".smethod_2(CultureInfo.InvariantCulture, class28_0.TokenType, class28_0.Value));
	}
}
