using System;
using System.Globalization;
using Newtonsoft.Json;
using ns13;
using ns3;
using ns6;
using ns9;

namespace ns16;

internal class Class18 : Class15
{
	internal static readonly DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		long num;
		if (object_0 is DateTime dateTime)
		{
			num = (long)(dateTime.ToUniversalTime() - dateTime_0).TotalSeconds;
		}
		else
		{
			if (!(object_0 is DateTimeOffset dateTimeOffset))
			{
				throw new JsonSerializationException("Expected date object value.");
			}
			num = (long)(dateTimeOffset.ToUniversalTime() - dateTime_0).TotalSeconds;
		}
		if (num < 0L)
		{
			throw new JsonSerializationException("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
		}
		class37_0.vmethod_24(num);
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		bool flag = Class131.smethod_666(type_0);
		if (class28_0.TokenType == JsonToken.Null)
		{
			if (!flag)
			{
				throw Class131.smethod_38(class28_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		long result;
		if (class28_0.TokenType == JsonToken.Integer)
		{
			result = (long)class28_0.Value;
		}
		else
		{
			if (class28_0.TokenType != JsonToken.String)
			{
				throw Class131.smethod_38(class28_0, "Unexpected token parsing date. Expected Integer or String, got {0}.".smethod_1(CultureInfo.InvariantCulture, class28_0.TokenType));
			}
			if (!long.TryParse((string)class28_0.Value, out result))
			{
				throw Class131.smethod_38(class28_0, "Cannot convert invalid value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
		}
		if (result >= 0L)
		{
			DateTime dateTime = dateTime_0;
			DateTime dateTime2 = dateTime.AddSeconds(result);
			if ((flag ? Nullable.GetUnderlyingType(type_0) : type_0) == typeof(DateTimeOffset))
			{
				return new DateTimeOffset(dateTime2, TimeSpan.Zero);
			}
			return dateTime2;
		}
		throw Class131.smethod_38(class28_0, "Cannot convert value that is before Unix epoch of 00:00:00 UTC on 1 January 1970 to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
	}
}
